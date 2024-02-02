using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Inf04_01WpfApp.Model
{
    class MainModel
    {
        public string postCodeStr;
        public string streetWithNumber;
        public string city;
        public string showText;
        public string imageSource;
        public bool bPackage;
        public bool bLetter;
        public bool bPostcard;

        public MainModel()
        {
            postCodeStr = string.Empty;
            streetWithNumber = string.Empty;
            city = string.Empty;
            showText = string.Empty;

            bLetter = false;
            bPostcard = false;
            bPackage = false;

            imageSource = "/pliki/pocztowka.png";
        }
    }
}
