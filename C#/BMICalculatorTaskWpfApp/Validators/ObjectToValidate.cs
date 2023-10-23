using BMICalculatorTaskWpfApp.Validators.StacicClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace BMICalculatorTaskWpfApp.Validators
{
    class ObjectToValidate : IValidate
    {
        //-----------------------
        // PROPERTIES & VARIABLES
        public string ObjectName {  get; set; }
        public string Value { get; set; }

        public float ValueMinRange {  get; set; }
        public float ValueMaxRange {  get; set; }

        //-----------------------
        // FUNCTIONS
        public bool Validation(out string message)
        {
            if (!ValidateString.ValidateValueEmpty(Value, out message)
            || !ValidateNumber.CheckIsNumber(Value, out message)
                || !ValidateNumber.CheckIsInRange(float.Parse(Value), ValueMinRange, ValueMaxRange, out message))
            {
                message = ObjectName + message;
                return false;
            }

            message = string.Empty;
            return true;
        }
    }
}
