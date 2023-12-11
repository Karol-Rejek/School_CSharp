using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilsWpf;

namespace SimpleCalculatorMVVMWpfApp
{
    public class MainViewModel : ObserverVM
    {

        private int firstNumber;
        public int FirstNumber
        {
            get { return firstNumber; }
            set
            {
                firstNumber = value;
                OnPropertyChanged(nameof(FirstNumber));
            }
        }

        private int secoundNumber;
        public int SecoundNumber
        {
            get { return secoundNumber; }
            set
            {
                secoundNumber = value;
                OnPropertyChanged(nameof(SecoundNumber));
            }
        }

        private string result;
        public string Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public ICommand AddCommand { get; set; }
        public ICommand SubCommand { get; set; }

        private ICommand mulCommand;
        public ICommand MulCommand
        {
            get
            {
                if (mulCommand == null)
                    mulCommand = new RelayCommand<object>(
                        o =>
                        {
                            Result = "Wynik mnożenia: " + (FirstNumber * SecoundNumber).ToString();
                        }
                        );
                return mulCommand;
            }
        }


        private ICommand multiTaskCommand;
        public ICommand MultiTaskCommand
        {
            get
            {
                if (multiTaskCommand == null)
                    multiTaskCommand = new RelayCommand<string>(
                        operationSign =>
                        {
                            switch (operationSign)
                            {
                                case "+":
                                    Result = "Wynik dzielenia: " + (FirstNumber + SecoundNumber).ToString();
                                    break; 
                                case "-":
                                    Result = "Wynik dzielenia: " + (FirstNumber - SecoundNumber).ToString();
                                    break;
                                case "*":
                                    Result = "Wynik dzielenia: " + (FirstNumber * SecoundNumber).ToString();
                                    break;
                                case "/":
                                    Result = "Wynik dzielenia: " + (FirstNumber / SecoundNumber).ToString();
                                    break;
                                default:
                                    break;
                            }
                        });
                return multiTaskCommand;
            }
        }

        public MainViewModel()
        {
            AddCommand = new RelayCommand<object>(Add);
            SubCommand = new RelayCommand<object>((object o) /*Może być też (o)*/=>  Result = "Wynik ogejmowania: " + (FirstNumber - SecoundNumber).ToString() );
            
        }
        
        private void Add(object o)
        {
            Result = "Wynik dodawania: " + (FirstNumber + SecoundNumber).ToString();
        }
    }
}
