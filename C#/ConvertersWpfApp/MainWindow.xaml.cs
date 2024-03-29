﻿using System;
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

namespace ConvertersWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //-----------------------
        // PROPERTIES & VARIABLES

        private double redComponent;
        public double RedComponent
        {
            get { return redComponent; }
            set
            {
                redComponent = value;
                OnPropertyChanged(nameof(RedComponent));
            }
        } 

        private double greenComponent;
        public double GreenComponent
        {
            get { return greenComponent; }
            set
            {
                greenComponent = value;
                OnPropertyChanged(nameof(GreenComponent));
            }
        } 
        
        private double blueComponent;
        public double BlueComponent
        {
            get { return blueComponent; }
            set
            {
                blueComponent = value;
                OnPropertyChanged(nameof(BlueComponent));
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
            RedComponent = 255.0;
            GreenComponent = 0.0;
            BlueComponent = 0.0;
        }
    }
}
