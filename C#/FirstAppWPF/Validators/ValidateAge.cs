using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppWPF
{
    public class ValidateAge
    {
        #region Age Validation
        public bool ValidationAge(string userAge, out string message)
        {
            if (!CheckIsNumber(userAge, out message) || !CheckIsRealAge(int.Parse(userAge), out message))
            {
                return false;
            }
            return true;
        }

        private bool CheckIsNumber(string value, out string message)
        {
            int outputValue;
            if (!int.TryParse(value, out outputValue))
            {
                message = "Wiek musi być liczbą";
                return false;
            }
            message = string.Empty;
            return true;
        }

        private bool CheckIsRealAge(int userAge, out string message)
        {
            if (!(userAge > 1 && userAge <= 150))
            {
                message = "Wiek nie jest z przedziału <1, 150>";
                return false;
            }
            message = string.Empty;
            return true;
        }
        #endregion
    }
}
