using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace BindowanieWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //-----------------------
        // PROPERTIES & VARIABLES

        public string SourceValue { get; set; }
        public string StringNumberOfWeek { get; set; }

        private string nameDayOfWeek;
        public string NameDayOfWeek 
        { 
            get
            {
                return nameDayOfWeek;
            }
            set
            {
                nameDayOfWeek = value;
                //OnPropertyChanged(nameof(NameDayOfWeek));
                OnPropertyChanged();
            }
        }


        //-----------------------
        // FUNCTIONS
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Informowanie bindowania
        //-----------------------
        // EVENT
        public event PropertyChangedEventHandler? PropertyChanged;

        //-----------------------
        // FUNCTIONS
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = userValueTextBox.Text;
            textBlockWynik.Text = value;
        }

        private void userValueTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string value = userValueTextBox.Text;
            textBlockWynik.Text = value;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Zawartosc: " + SourceValue);
        }

        private void ButtonShowDayOfWeek_Click(object sender, RoutedEventArgs e)
        {
            switch (StringNumberOfWeek)
            {
            case "1":
                NameDayOfWeek = "Poniedzialek";
                //OnPropertyChanged("NameDayOfWeek");
                break;
            case "2":
                NameDayOfWeek = "Wtorek";
                break;
            case "3":
                 NameDayOfWeek = "Sroda";
                break; 
            case "4":
                NameDayOfWeek = "Czwartek";
                break;
            default:
                NameDayOfWeek = "Blendne dane";
                break;
            }
            //OnPropertyChanged(nameof(NameDayOfWeek));

        }
    }
}
