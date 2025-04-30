import requests
from bs4 import BeautifulSoup
from urllib.parse import urljoin
import time
import schedule
import json
import re
from datetime import datetime
import os

# 🔧 KONFIGURACJA
QUERY = "iphone"
BASE_URL = f"https://www.olx.pl/oferty/q-{QUERY}/?search%5Border%5D=created_at:desc"
DISCORD_WEBHOOK_URL = "https://discord.com/api/webhooks/1367055364662497280/xuhWEhHPBf33H9N-lvogp9eSeSBnIH6H1xohtKJ1vGGnEKmdxivJpJxRDvHPc7DFjL58"
SEEN_FILE = "seen_urls.json"

# 📁 Wczytywanie zapamiętanych URL-i (z obsługą pustych/uszkodzonych plików)
def load_seen_urls():
    if os.path.exists(SEEN_FILE):
        try:
            with open(SEEN_FILE, "r") as f:
                data = f.read().strip()
                if not data:
                    return set()
                return set(json.loads(data))
        except (json.JSONDecodeError, ValueError):
            print("⚠️ Błąd w pliku seen_urls.json – zostaje zignorowany.")
            return set()
    return set()

# 💾 Zapisywanie nowego URL-a
def save_seen_url(url):
    seen = load_seen_urls()
    seen.add(url)
    with open(SEEN_FILE, "w") as f:
        json.dump(list(seen), f)

# 📤 Wysyłanie embedów do Discorda
def send_to_discord_embed(offers):
    embeds = []
    for offer in offers:
        embeds.append({
            "title": offer["title"],
            "description": f"Cena: {offer['price']}",
            "url": offer["url"],
            "image": {"url": offer["image"]} if offer["image"] else {},
            "color": 0x00b0f4
        })

    data = {"embeds": embeds}
    response = requests.post(DISCORD_WEBHOOK_URL, json=data)

    if response.status_code != 204:
        print(f"❌ Błąd wysyłania do Discorda: {response.status_code} - {response.text}")
    else:
        print("✅ Wysłano ogłoszenia na Discorda")

# 🔍 Pobieranie szczegółów ogłoszenia
def get_offer_details(url):
    headers = {"User-Agent": "Mozilla/5.0"}
    response = requests.get(url, headers=headers)
    soup = BeautifulSoup(response.text, "html.parser")

    price_tag = (
        soup.find("h3", {"data-testid": "ad-price-container"}) or
        soup.find("div", {"data-testid": "ad-price-container"}) or
        soup.find("span", string=lambda s: s and "zł" in s)
    )
    price = price_tag.get_text(strip=True) if price_tag else "brak"

    image_tag = soup.select_one("div.swiper-zoom-container img") or soup.select_one("img")
    image_url = image_tag.get("src") if image_tag else None

    description_tag = soup.find("div", {"data-testid": "ad-description"})
    description = description_tag.get_text(strip=True).lower() if description_tag else ""

    return price, image_url, description

# 🔄 Pobieranie ogłoszeń
def get_offers():
    seen_urls = load_seen_urls()
    headers = {"User-Agent": "Mozilla/5.0"}
    response = requests.get(BASE_URL, headers=headers)
    soup = BeautifulSoup(response.text, "html.parser")
    cards = soup.select("div[data-testid='listing-grid'] a[href]")

    offers = []

    # ❌ Ignorowane słowa – akcesoria itp.
    excluded_keywords = [
        "case", "etui", "pokrowiec", "ładowarka", "kabel", "adapter",
        "szkło", "folie", "szyba", "obudowa", "bateria", "uchwyt"
    ]

    for offer in cards:
        href = offer.get("href")
        if not href or not href.startswith("/d/oferta/"):
            continue

        full_url = urljoin("https://www.olx.pl", href.split("#")[0])
        if full_url in seen_urls:
            continue

        title = offer.get_text(strip=True)[:100]
        price, image_url, description = get_offer_details(full_url)

        combined_text = f"{title.lower()} {description}"

        if QUERY.lower() not in combined_text:
            continue

        if any(ex_word in combined_text for ex_word in excluded_keywords):
            continue

        offers.append({
            "title": title,
            "price": price,
            "url": full_url,
            "image": image_url
        })

        save_seen_url(full_url)

        if len(offers) >= 5:
            break

    return offers

# 🧠 Główna funkcja
def main():
    print(f"[{datetime.now().strftime('%H:%M:%S')}] 🔎 Sprawdzam OLX...")
    offers = get_offers()
    if offers:
        send_to_discord_embed(offers)
    else:
        print("ℹ️ Brak nowych ogłoszeń ze słowem kluczowym.")

# 🔁 Harmonogram co 1 minutę
if __name__ == "__main__":
    schedule.every(1).minutes.do(main)
    print("🚀 Bot działa — sprawdza OLX co 1 minutę...")
    while True:
        schedule.run_pending()
        time.sleep(1)
