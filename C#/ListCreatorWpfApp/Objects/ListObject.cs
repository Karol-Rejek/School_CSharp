using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCreatorWpfApp.Objects
{
    struct TextData
    {
        public string name;
    }

    struct NumericData 
    {
        public int quantity;  
    }

    class ListObject
    {
        public TextData textData;
        public NumericData numericData;
    }
}
