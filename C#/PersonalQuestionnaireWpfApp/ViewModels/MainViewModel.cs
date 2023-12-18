﻿using PersonalQuestionnaireWpfApp.Models;
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
        
        public bool CheckResult
        {
            get { return personalDataModel.bPizzaWithPineapple; }
            set
            {
                personalDataModel.bPizzaWithPineapple = value;
                OnPropertyChanged(nameof(CheckResult));
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

                            QuestionnaireResult = result;
                        }
                        );
                return downloadDataCommand;
            }
        }
    }
}
