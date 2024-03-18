using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginListApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddToListPage : ContentPage
    {
        public AddToListPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Back(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void Button_Clicked_AddToList(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }
    }
}