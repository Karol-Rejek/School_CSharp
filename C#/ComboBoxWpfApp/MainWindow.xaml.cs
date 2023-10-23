using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        //-----------------------
        // PROPERTIES & VARIABLES

        public ObservableCollection<string> ItemsList { get; set; }

        public string OptionToList { get; set; }

        //private List<string> itemsList;
        //public List<string> ItemsList
        //{
        //    get { return itemsList; }
        //    set
        //    {
        //        itemsList = value;
        //        OnPropertyChanged(nameof(ItemsList));
        //    }
        //}

        public ObservableCollection<OwnColor> OwnColorsColection { get; set; }

        //-----------------------
        // FUNCTIONS
        public MainWindow()
        {
            OwnColorsColection = new ObservableCollection<OwnColor>();
            OnPropertyChanged(nameof(OwnColorsColection));
            OwnColorsColection.Add(new OwnColor() { NameOfColor_Pol = "Czerwony", NameOfColor_Eng = "Red" });
            OwnColorsColection.Add(new OwnColor() { NameOfColor_Pol = "Zielony", NameOfColor_Eng = "Green" });
            OwnColorsColection.Add(new OwnColor() { NameOfColor_Pol = "Niebieski", NameOfColor_Eng = "Blue" });


            InitializeComponent();
            ItemsList = new ObservableCollection<string>();
            OnPropertyChanged(nameof(ItemsList));
            ItemsList.Add("Opcja 1");
            ItemsList.Add("Opcja 2");
            ItemsList.Add("Opcja 3");
            ItemsList.Add("Opcja 4");
            ItemsList.Add("Opcja 5");
        }

        #region Informowanie bindowania
        //-----------------------
        // EVENT
        public event PropertyChangedEventHandler? PropertyChanged;

        //-----------------------
        // FUNCTIONS
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public void AddItemToList(string newItem)
        {
            if (newItem != null)
            {
                ItemsList.Add(newItem);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddItemToList(OptionToList);
        }
    }
}
