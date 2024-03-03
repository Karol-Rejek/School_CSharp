using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf04_01WpfApp.Classes.Validators.StaticClasses
{
    static class ValidateString
    {
        public static bool ValidateLenght(string x, out string message)
        {
            if (x.Length != 5)
            {
                message = "Nieprawidłowa liczba cyfr w kodzie pocztowym";
                return true;
            }
            message = string.Empty;
            return false;
        }

        public static bool ValidateChar(string x, out string message)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < '0' || x[i] > '9')
                {
                    message = "Kod pocztowy powinien składać się z samych cyfr";
                    return true;
                }
            }
            message = string.Empty;
            return false;
        }
    }
}
