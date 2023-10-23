using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWPF
{
    public class Validate
    {
        public bool Validation(string userName, string userAge, out string message)
        {
            if (!new ValidateName().ValidationName(userName, out message) || !new ValidateAge().ValidationAge(userAge, out message))
            {
                return false;
            }
            return true;

            //foreach (var item in collection)
            //{
            //    if(!item.Validation())
            //    {

            //    }
            //}

        }

        public bool CheckIfVariablesAreEmpty(string userName, string userAge, out string message)
        {
            if(ValidateValueEmpty(userName))
            {
                message = "[Imie]";
                return true;
            }

            if (ValidateValueEmpty(userAge))
            {
                message = "[Wiek]";
                return true;
            }

            message = string.Empty;
            return false;
            
        }

        private bool ValidateValueEmpty(string value)
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                return true;
            }
            return false;
        }
    }
}
