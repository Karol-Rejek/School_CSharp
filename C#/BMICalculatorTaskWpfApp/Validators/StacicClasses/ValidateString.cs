using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorTaskWpfApp.Validators.StacicClasses
{
    static class ValidateString
    {
        public static bool ValidateValueEmpty(string value, out string message)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                message = string.Empty;
                return true;
            }
            message = "- Nie Wprowaczono Danych";
            return false;
        }
    }
}
