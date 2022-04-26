using System;
using System.Collections.Generic;
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

namespace Temperatura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public string Dana_z_kodu_do_widoku{ get; set; }
        public string Dana_z_widoku_do_kodu { get; set; }
    public MainWindow()
        {
            InitializeComponent();
             
    }
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBlockWynik.Text = TextBoxWartosc.Text;
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Dana_z_widoku_do_kodu, out int liczba))
            {
                liczba = liczba * 2;
                Dana_z_kodu_do_widoku = liczba.ToString();
                OnPropertyChanged("Dana_z_kodu_do_widoku");
            }
            else
            {
                Dana_z_kodu_do_widoku = "Podano wartość nie będącą liczbą !!!";
                OnPropertyChanged(nameof(Dana_z_kodu_do_widoku));
            }

        }
}
