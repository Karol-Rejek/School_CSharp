using PersonalQuestionnaireWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilsWpf;

namespace PersonalQuestionnaireWpfApp.ViewModels
{
    public class MainViewModel : ObserverVM
    {
        private PersonalDataModel personalDataModel = new PersonalDataModel();
        
        public string Name
        {
            get { return personalDataModel.name; }
            set
            {
                personalDataModel.name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string SelectedDish
        {
            get { return personalDataModel.selectedDish; }
            set
            {
                personalDataModel.selectedDish = value;
                OnPropertyChanged(nameof(SelectedDish));
            }
        } 
        
        public bool CheckResult
        {
            get { return personalDataModel.bPizzaWithPineapple; }
            set
            {
                personalDataModel.bPizzaWithPineapple = value;
                OnPropertyChanged(nameof(CheckResult));
            }
        }
                
        public bool Male
        {
            get { return personalDataModel.bMale; }
            set
            {
                personalDataModel.bMale = value;
                OnPropertyChanged(nameof(Male));
            }
        }

        public bool Female
        {
            get { return personalDataModel.bFemale; }
            set
            {
                personalDataModel.bFemale = value;
                OnPropertyChanged(nameof(Female));
            }
        }

        public List<string> ListOfDish
        {
            get { return personalDataModel.listOfDish; }
            set
            {
                personalDataModel.listOfDish = value;
                OnPropertyChanged(nameof(ListOfDish));
            }
        }

        private string questionnaireResult;
        public string QuestionnaireResult
        {
            get { return questionnaireResult; }
            set
            {
                questionnaireResult = value;
                OnPropertyChanged(nameof(QuestionnaireResult));
            }
        }

        private ICommand downloadDataCommand;
        public ICommand DownloadDataCommand
        {
            get
            {
                if (downloadDataCommand == null)
                    downloadDataCommand = new RelayCommand<object>(
                        o =>
                        {
                            string result = "";
                            result += "Imię: " + Name + "\n";
                            result += "Pizza z ananasem: " + (CheckResult ? "Tak" : "Nie") + "\n";
                            result += "Płeć: " + (Male ? "Mężczyzna" : "Kobieta") + "\n";
                            result += "Ulubione danie: " + SelectedDish + "\n";
                            QuestionnaireResult = result;
                        }
                        );
                return downloadDataCommand;
            }
        }
    }
}
