using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalQuestionnaireWpfApp.Models
{
    public struct PersonalDataModel
    {
        public string name;
        public string selectedDish;

        public bool bPizzaWithPineapple;
        public bool bMale;
        public bool bFemale;

        public List<string> listOfDish; 

        public PersonalDataModel()
        {
            name = string.Empty;

            bPizzaWithPineapple = false;
            bMale = false;
            bFemale = false;

            listOfDish = new List<string>()
            {
                "rosół", "schabowy", "mielone", "kebab"
            };
            selectedDish = listOfDish.First();
        }
    }
}
