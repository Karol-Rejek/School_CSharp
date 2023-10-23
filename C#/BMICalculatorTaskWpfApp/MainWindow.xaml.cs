using BMICalculatorTaskWpfApp.Validators;
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

namespace BMICalculatorTaskWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        //-----------------------
        // PROPERTIES & VARIABLES

        public string UserWeight { get; set; }
        public string UserHeight { get; set; }


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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<IValidate> listOfValuesToValidation = new List<IValidate>();
            listOfValuesToValidation.Add(new ObjectToValidate() 
            { 
                ObjectName = "[Masa Ciała] ",
                Value = UserWeight,
                ValueMinRange = 1.0f,
                ValueMaxRange = 400.0f
            });
            listOfValuesToValidation.Add(new ObjectToValidate() 
            { 
                ObjectName = "[Wzrost] ", 
                Value = UserHeight,
                ValueMinRange = 1.0f,
                ValueMaxRange = 300.0f,
            });

            //listOfValuesToValidation.Add(new ObjectToValidate()
            //{
            //    ObjectName = "[Imię] ",
            //    Value = "Jan",
            //    ValueMinRange = 1.0f,
            //    ValueMaxRange = 300.0f,
            //});

            string message;
            string color = "";

            MessageToShow = new Validate().Validation(listOfValuesToValidation, out message) ? WhatIsUserBMI(CalculateBMI(float.Parse(UserWeight), float.Parse(UserHeight)), out color) 
                                                                                             : message;
            MessageColor = color;
        }

        private string WhatIsUserBMI(float BMI, out string messageColor)
        {
            return "Tweje BMI wynosi: " + Math.Round(BMI,2).ToString() + " / " + WhatFollowsFromBMI(BMI, out messageColor);
        }

        private string WhatFollowsFromBMI(float BMI, out string messageColor)
        {
            if (BMI < 16.0f)
            {
                messageColor = "DarkSlateGray";
                return "Wygłodzenie";
            }

            if(BMI >= 16.0f && BMI <= 16.99f)
            {
                messageColor = "DimGray";
                return "Wychudzenie";
            }

            if(BMI >= 17f &&  BMI <= 18.49f)
            {
                messageColor = "CadetBlue";
                return "Niedowaga";
            }

            if(BMI >= 18.5f && BMI <= 24.99f)
            {
                messageColor = "Green";
                return "Waga Prawidłowa";
            }

            if(BMI >= 25.0f && BMI <= 29.9f)
            {
                messageColor = "Orange";
                return "Nadwaga";
            }

            if (BMI >= 20.0f && BMI <= 34.99f)
            {
                messageColor = "OrangeRed";
                return "1 Stopień Otyłaści";
            }

            if(BMI >= 35.0f && BMI <= 39.99f)
            {
                messageColor = "Red";
                return "2 Stopień Otyłości";
            }

            if(BMI >= 40.0f)
            {
                messageColor = "DarkRed";
                return "Otyłość Skrajna";
            }

            messageColor = string.Empty;
            return string.Empty;
        }

        private float CalculateBMI(float weight, float height)
        {
            return weight / (height/100 * height/100);
        }
    }
}
