using System;

namespace ProgramPesel
{
    internal class Pesel
    {
        private string numerPesel;
       
        public Pesel(string numerPesel)
        {
            this.numerPesel = numerPesel;
            Walidacja();
        }
        private void Walidacja()
        {
           // GenerowanieDniRokuPrzestepnego();
            WalidacjaPoprawnoscDlugosci();
            WalidacjaPoprawnosciZnakow();
            WalidacjaPoprawnosciMiesiaca();
            WalidacjaPoprawnosciDnia();
            WalidacjaPoprawnosciCyfryKontrolnej();
        }

       
        #region walidacja
        private void WalidacjaPoprawnosciCyfryKontrolnej()
        {
            {
                int control = 0;

                int[] wzor = { 1, 3, 7, 9 };

                int k = 0;
                for (int i = 0; i < 11; i++)
                {
                    if (k > 3)
                        k = 0;

                    if (i == 10)
                        k = 0;

                    control += int.Parse(numerPesel[i].ToString()) * wzor[k];
                    k++;
                }

                if (control % 10 != 0)
                    throw new Exception("Podana liczba kontrolna się nie zgadza");
            }
        }
        private void WalidacjaPoprawnosciMiesiaca()
        {
            int miesiac = LiczMiesiac();
            if (miesiac > 12 || miesiac < 1)
                throw new Exception("Podano niepoprawny miesiac");
        }

        private void WalidacjaPoprawnosciDnia()
        {
            int dzien = LiczDzien();
            int miesiac = LiczMiesiac();
            int rok = LiczRok();
            int[] trzyzero = { 4, 6, 9, 11 };

            if (dzien < 1 || dzien > 31)
                throw new Exception("Niepoprawny dzień. Poza zakresem 1-31");

            for (int i = 0; i < 4; i++)
                if (miesiac == trzyzero[i] && dzien > 30)
                    throw new Exception("Niepoprawny dzień. W tym miesiacu dzien powinien miec 30 dni)");

            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                if (miesiac == 2 && dzien != 29)
                    throw new Exception("Niepoprwany dzień. W roku przestepnym luty ma 29 dni");
            }
            else
            {
                if (miesiac == 2 && dzien != 28)
                    throw new Exception("Niepoprwany dzień. W roku nieprzestepnym luty ma 28");
            }
        }

        private void WalidacjaPoprawnoscDlugosci()
        {
            if (numerPesel.Length != 11)
            {
                throw new Exception("Zła długość numeru pesel");

            }
            var isGood = int.TryParse(numerPesel, out _);
        }

        private void WalidacjaPoprawnosciZnakow()
        {
            for (int i = 0; i < 11; i++)
            {
                if (!IsNumber(numerPesel[i]))
                    throw new Exception("Podany pesel zawiera niedozwolone znaki");
            }
        }
        #endregion
        #region metody publiczne
        public int Miesiac
        {

            get
            {
                return LiczMiesiac();
            }
        }
        public string Miesiacopis
        {
            get
            {


                switch (LiczMiesiac())
                {
                    case 1:
                        return "styczen";
                    case 2:
                        return "luty";
                    case 3:
                        return "marzec";
                    case 4:
                        return "kwiecien";
                    case 5:
                        return "maj";
                    case 6:
                        return "czerwiec";
                    case 7:
                        return "lipiec";
                    case 8:
                        return "sierpien";
                    case 9:
                        return "wrzesien";
                    case 10:
                        return "pazdziernik";
                    case 11:
                        return "listopad";
                    case 12:
                        return "grudzien";
                    default:
                        return "";
                }



            }
        }
        public int Dzien
        {
            get
            {
                return LiczDzien();
            }

        }
       /* public string Plec
        {
            get
            {
                return numerPesel[9].ToString();
             }
        }
       */
        public string PlecOpis
        {
            get
            {
                int plec = int.Parse(numerPesel[9].ToString());
                if (plec % 2 == 0)
                    return "Kobieta";
                else
                    return "Mężczyzna";
            }

        }
        public int Rok
        {
            get
            {
                return LiczRok();
            }
        }


        /*public string MiesiacOpis
       {
           get
           {
               int miesiac = int.Parse(numerPesel[2].ToString() + numerPesel[3].ToString()) % 20;
               switch (miesiac)
               {
                   case 1:
                       miesiac =('styczen');
                       break;
                   case 2:
                       miesiac = 'luty';
                       break;
                   case 3:
                       miesiac = 'marzec';
                       break;
                   case 4:
                       miesiac = 'kwiecien';
                       break;
                   case 5:
                       miesiac = 'maj';
                       break;
                   case 6:
                       miesiac = 'czerwiec';
                       break;
                   case 7:
                       miesiac = 'lipiec';
                       break;
                   case 8:
                       miesiac = 'sierpien';
                       break;
                   case 9:
                       miesiac = 'wrzesien';
                       break;
                   case 10:
                       miesiac = 'pazdzienrik';
                       break;
                   case 11:
                       miesiac = 'listopad';
                       break;
                   case 12:
                       miesiac = 'grudzien';
                       break;
               }
       }
       }
       */
        #endregion
        #region prywatne metody
        private bool IsNumber(char x)
        {
            if (x >= '0' && x <= '9')
                return true;
            else
                return false;
        }
        private int LiczMiesiac()
        {
            int miesiac = int.Parse(numerPesel.Substring(2, 2));
            miesiac %= 20;
            return miesiac;
        }
        private int LiczRok()
        {
            int rok = int.Parse(numerPesel.Substring(0, 2));
            int miesiac = int.Parse(numerPesel.Substring(2, 2));

            switch (miesiac / 20)
            {
                case 0:
                    return 1900 + rok;
                case 1:
                    return 2000 + rok;
                case 2:
                    return 2100 + rok;
                case 3:
                    return 2200 + rok;
                case 4:
                    return 1800 + rok;
                default:
                    return 0;
            }
        }

            private int LiczDzien()
        {
            return int.Parse(numerPesel.Substring(4, 2));
        }

        /*private void GenerowanieDniRokuPrzestepnego()
       {
           throw new NotImplementedException();
       }*/

        /*private void WalidacjaPoprawnosciCyfryKontrolnej()

        { 
            int liczbaKontrolna = int.Parse(numerPesel[numerPesel.Length - 1].ToString());
            int wynik = 0;
            int[] mnoznik = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            for (int i = 0; i >10; i++)
            {
                liczbaKontrolna = (int.Parse(numerPesel[i].ToString()) * mnoznik[i]);
            }
            if (liczbaKontrolna > 10)
            {
                wynik += liczbaKontrolna % 10;
              
            }
            else { wynik += liczbaKontrolna; }
            throw new Exception ();
        }*/
        #endregion


    }
}