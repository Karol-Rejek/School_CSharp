using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //-----------------------
        // PROPERTIES & VARIABLES
        public string UserName { get; set; }
        public string UserAge { get; set; }

        private string messageToShow;
        public string MessageToShow
        {
            get { return messageToShow; }
            set
            {
                messageToShow = value;
                OnPropertyChanged(nameof(MessageToShow));
            }
        }

        private string messageColor;
        public string MessageColor
        {
            get { return messageColor; }
            set
            {
                messageColor = value;
                OnPropertyChanged(nameof(MessageColor));
            }
        }

        string textColor;
        

        #region Informowanie bindowania
        //-----------------------
        // EVENT
        public event PropertyChangedEventHandler? PropertyChanged;

        //-----------------------
        // FUNCTIONS
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        //-----------------------
        // FUNCTIONS
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonSend_Click(object sender, RoutedEventArgs e)
        {
            string message;
            MessageToShow = new Validate().CheckIfVariablesAreEmpty(UserName,UserAge, out message) ? CheckUserData(UserName.Trim(), UserAge.Trim(), out textColor) : "Nie wprowadzono pola " + message;
            MessageColor = textColor;
        }

        private string CheckUserData(string userName, string userAge, out string textColor)
        {
            string message;
            if (new Validate().Validation(userName, userAge, out message))
            {
                textColor = "Green";
                return userName + " " + userAge + " / " + IsOfAge(int.Parse(userAge));
            }
            textColor = "DarkRed";
            return message;
        }

        private string IsOfAge(int age)
        {
            return age >= 18 ? "Osoba pełnoletnia" : "Osoba niepełnoletnia";
        }
    }
}
