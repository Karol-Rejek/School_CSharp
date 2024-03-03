using Inf04_01WpfApp.Classes.Validators.StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inf04_01WpfApp.Classes.Validators
{
    class Validate
    {
        public bool Validation(string x, out string message)
        {
            string m = string.Empty;
            if (string.IsNullOrEmpty(x) || ValidateString.ValidateLenght(x, out m) || ValidateString.ValidateChar(x, out m))
            {
                message = m;
                return false;
            }
            message = string.Empty;
            return true;
        }
    }
}
