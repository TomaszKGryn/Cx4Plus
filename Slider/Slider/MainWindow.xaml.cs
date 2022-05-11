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

namespace Slider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,INotifyPropertyChanged
    {
        private double _redComponent;
        public double RedComponent
        {
            get
            {
                return _redComponent;
            }
            set
            {
                _redComponent = value;
                OnPropertyChanged(nameof(RedComponent));
            }
        }
        private double _greenComponent;
        public double GreenComponent
        {
            get
            {
                return _greenComponent;
            }
            set
            {
                _greenComponent = value;
                OnPropertyChanged(nameof(GreenComponent));
            }
        }
        private double _blueComponent;
        public double BlueComponent
        {
            get
            {
                return _blueComponent;
            }
            set
            {
                _blueComponent = value;
                OnPropertyChanged(nameof(BlueComponent));
                
            }
        }

        public object ColorShape
        {
            get
            {
                return 1;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
