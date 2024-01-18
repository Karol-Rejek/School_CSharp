using ListCreatorWpfApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCreatorWpfApp.Models
{
    class ShopListDataModel
    {
        public string name;

        public string quantity;

        public string checkText;

        public string listNameText;

        public string listQuantityText;

        public List<ListObject> shopList = new List<ListObject>();
    }
}
