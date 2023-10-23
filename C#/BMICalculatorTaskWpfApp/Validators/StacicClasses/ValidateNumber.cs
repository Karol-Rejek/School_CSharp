using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorTaskWpfApp.Validators.StacicClasses
{
    static class ValidateNumber
    {
        //-----------------------
        // FUNCTIONS
        public static bool CheckIsNumber(string value, out string message)
        {
            float outputValue;
            if (!float.TryParse(value, out outputValue))
            {
                message = "musi być liczbą";
                return false;
            }
            message = string.Empty;
            return true;
        }

        public static bool CheckIsInRange(float value, float min, float max, out string message) 
        {
            if(value < min || value > max)
            {
                message = "przekroczono zakres od " + min + " do " + max;
                return false;
            }

            message = string.Empty;
            return true;      
        }
    }
}
