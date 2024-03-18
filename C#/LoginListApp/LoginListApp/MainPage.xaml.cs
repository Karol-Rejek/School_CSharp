using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LoginListApp.Pages;

namespace LoginListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_List(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListPage());
        }

        private void Button_Clicked_Info(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InfoPage());
        }
    }
}
