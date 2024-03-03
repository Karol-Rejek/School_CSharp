using Inf04_01WpfApp.Classes.Validators;
using Inf04_01WpfApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using UtilsWpf;

namespace Inf04_01WpfApp.Viewmodel
{
    class MainViewModel : ObserverVM
    {
        MainModel dataModel  = new MainModel();

        public string City
        {
            get { return dataModel.city; }
            set
            {
                dataModel.city = value;
                OnPropertyChanged(nameof(City));
            }
        }

        public string PostCodeStr
        {
            get { return dataModel.postCodeStr; }
            set
            {
                dataModel.postCodeStr = value;
                OnPropertyChanged(nameof(PostCodeStr));
            }
        }
        public string StreetWithNumber
        {
            get { return dataModel.streetWithNumber; }
            set
            {
                dataModel.streetWithNumber = value;
                OnPropertyChanged(nameof(StreetWithNumber));
            }
        }
        public string ShowText
        {
            get { return dataModel.showText; }
            set
            {
                dataModel.showText = value;
                OnPropertyChanged(nameof(ShowText));
            }
        }
        public string ImageSource
        {
            get { return dataModel.imageSource; }
            set
            {
                dataModel.imageSource = value;
                OnPropertyChanged(nameof(ImageSource));
            }
        }

        public bool Package
        {
            get { return dataModel.bPackage; }
            set
            {
                dataModel.bPackage = value;
                OnPropertyChanged(nameof(Package));
            }
        }

        public bool Letter
        {
            get { return dataModel.bLetter; }
            set
            {
                dataModel.bLetter = value;
                OnPropertyChanged(nameof(Letter));
            }
        }

        public bool Postcard
        {
            get { return dataModel.bPostcard; }
            set
            {
                dataModel.bPostcard = value;
                OnPropertyChanged(nameof(Postcard));
            }
        }

        private ICommand checkPriceCommand;
        public ICommand CheckPriceCommand
        {
            get
            {
                checkPriceCommand ??= new RelayCommand<object>(
                        o =>
                        {
                            if(Postcard)
                            {
                                ImageSource = "/pliki/pocztowka.png";
                                ShowText = "Cena: 1zł"; 
                            }
                            if (Letter)
                            {
                                ImageSource = "/pliki/list.png";
                                ShowText = "Cena: 1,5zł";
                            }
                            if (Package)
                            {
                                ImageSource = "/pliki/paczka.png";
                                ShowText = "Cena: 10zł";
                            }
                        }
                        );
                return checkPriceCommand;
            }
        }

        private ICommand confirmCommand;
        public ICommand ConfirmCommand
        {
            get
            {
                confirmCommand ??= new RelayCommand<object>(
                        o =>
                        {
                            if (!new Validate().Validation(PostCodeStr, out string message))
                            {
                                MessageBox.Show(message);
                            }
                            else 
                            {
                                MessageBox.Show("Dane przesyłki zostały wprowadzone");
                            }
                        }
                        );
                return confirmCommand;
            }
        }

        
    }
}
