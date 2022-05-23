using PierwszyProjektMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilitisWPF;

namespace PierwszyProjektMVVM.ViewModel
{
    public class DaneVM : ObserverVM
    {
        private Dane dane;

        public string DanaWejsciowa
        {
            set
            {
                dane.DanaWejsciowa = value;
            }
        }

        public string DanaWyliczana
        {
            get
            {
                return dane.DanaWyliczana;
            }
            set
            {
                dane.DanaWyliczana = value;
                OnPropertyChanged();
            }
        }
        private bool czyAktywna;
        public bool CzyAktywny
        {
            get
            {
                return dane.CzyAktywny;
            }
            set
            {
                dane.CzyAktywny = value;
                OnPropertyChanged();
            }
        }
        private ICommand _wykonajObliczenia;
        public ICommand WykonajObliczenia
        {
            get
            {
                if (_wykonajObliczenia == null)
                {
                    _wykonajObliczenia = new RelayCommand<object>(WywolajMetode);
                }
                return _wykonajObliczenia;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void OnPropertyChanged()
        {
            throw new NotImplementedException();
        }


        public DaneVM()
        {
            dane = new Dane();
        }

        private void WywolajMetode(object parametr)
        {
            if (int.TryParse(dane.DanaWejsciowa, out int liczba))
            {
                liczba = liczba * liczba;
                DanaWyliczana = "Wynik operacji: " + liczba;
            }
            else
            {
                DanaWyliczana = "Podano nie liczbę.";
            }
        }
       
    }
}
