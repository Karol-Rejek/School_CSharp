using ListCreatorWpfApp.Models;
using ListCreatorWpfApp.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UtilsWpf;

namespace ListCreatorWpfApp.VievModels
{
    class MainVievModel : ObserverVM
    {
        private ShopListDataModel shopListData = new ShopListDataModel();

        public string Name
        {
            get { return shopListData.name; }
            set
            {
                shopListData.name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Quantity
        {
            get { return shopListData.quantity; }
            set
            {
                shopListData.quantity = value;
                OnPropertyChanged(nameof(Quantity));
            }
        }

        public string CheckText
        {
            get { return shopListData.checkText; }
            set
            {
                shopListData.checkText = value;
                OnPropertyChanged(nameof(CheckText));
            }
        }

        public string ListText
        {
            get { return shopListData.listText; }
            set
            {
                shopListData.listText = value;
                OnPropertyChanged(nameof(ListText));
            }
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                    addCommand = new RelayCommand<object>(
                        o =>
                        {
                            if (int.TryParse(Quantity,out int intQuantity))
                            {
                                ListObject newListObject = new ListObject();
                                newListObject.textData.name = Name;

                                if (shopListData.shopList.Contains(newListObject))
                                {
                                    foreach (var item in shopListData.shopList)
                                    {
                                        if (item.textData.name == Name)
                                        {
                                            item.numericData.quantity += intQuantity;
                                            CheckText = "Pomyślnie dodane do listy";
                                        }
                                    }
                                }
                                else
                                {
                                    newListObject.numericData.quantity = intQuantity;
                                    shopListData.shopList.Add(newListObject);
                                    CheckText = "Pomyślnie dodane do listy";
                                }
                            }
                        }
                        );
                return addCommand;
            }
        }

        private ICommand removeCommand;
        public ICommand RemoveCommand
        {
            get
            {
                removeCommand ??= new RelayCommand<object>(
                        o =>
                        {
                            foreach (var item in shopListData.shopList)
                            {
                                if(item.textData.name == Name)
                                {
                                    if (int.TryParse(Quantity, out int intQuantity))
                                    {
                                        if ((item.numericData.quantity - intQuantity) > 1)
                                        {
                                            item.numericData.quantity -= intQuantity;
                                            CheckText = "Pomyślnie usunięto z listy";
                                        }

                                        if(item.numericData.quantity == intQuantity)
                                        {
                                            shopListData.shopList.Remove(item);
                                            CheckText = "Pomyślnie usunięto z listy";
                                        }

                                        CheckText = "Błąd z usunięciem z listy\n" + "Sprubój ponownie";

                                    }
                                }
                            }
                        }
                        );
                return removeCommand;
            }
        }
    }
}
