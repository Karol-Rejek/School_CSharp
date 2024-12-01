using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EssentialApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FlashLight_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FlashLightPage());
        }
        
        private void SMS_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SMSPage());
        }

        private void URL_Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new URLPage());
        }
    }
}
