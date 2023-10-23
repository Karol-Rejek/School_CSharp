using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWPF
{
    public class ValidateName
    {
        #region Name Validation
        public bool ValidationName(string userName, out string message)
        {
            if (CheckNameHasLatters(userName, out message))
            {
                return true;
            }
            return false;
        }

        private bool CheckNameHasLatters(string userName, out string message)
        {
            if (!CheckStringIfHaveOnlyLetters(userName))
            {
                message = "Imie musi zawierać same litery";
                return false;
            }
            message = string.Empty;
            return true;
        }

        private bool CheckStringIfHaveOnlyLetters(string checkedValue)
        {
            foreach (char letter in checkedValue)
            {
                if (!((letter >= 'A' && letter <= 'Z') || (letter >= 'a' && letter <= 'z')))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
