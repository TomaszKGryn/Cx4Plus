using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace zadaniezawodowe
{
    public class Validation :MainWindow, INotifyPropertyChanged

    {
        public void ShowValid()
        {
            if (TextBoxName == null)
            {
                TextBlockName = "Podaj imię";
                OnPropertyChanged(nameof(TextBlockName));

                //MessageBox.Show("Podaj imię");
            }
            else
            {
                TextBlockName = "Witaj " + TextBoxName;
                OnPropertyChanged(nameof(TextBlockName));

                //MessageBox.Show("Witaj " + TextBoxImie);
            }
            int age;
            bool isNumber = int.TryParse(TextBoxAge, out age);
            if (TextBoxAge == null)
            {
                TextBlockAge = "Podaj wiek";
                OnPropertyChanged(nameof(TextBlockAge));
            }
            else
            {



                if (age > 0)
                {
                    TextBlockAge = "Poprawny Wiek";
                    OnPropertyChanged(nameof(TextBlockAge));
                    // MessageBox.Show("Poprawny wiek");
                    if (age >= 18)
                    {
                        TextBlockAge = "Pełnoletni";
                        OnPropertyChanged(nameof(TextBlockAge));
                        //MessageBox.Show("Pełnoletni");
                    }
                    else
                    {
                        TextBlockAge = "Niepełnoletni";
                        OnPropertyChanged(nameof(TextBlockAge));
                        //MessageBox.Show("Niepełnoletni");
                    }
                }
                else
                {
                    TextBlockAge = "Niepoprawny wiek";
                    OnPropertyChanged(nameof(TextBlockAge));
                }
            }

            OnPropertyChanged("TextBoxName");


        }



    }
}
