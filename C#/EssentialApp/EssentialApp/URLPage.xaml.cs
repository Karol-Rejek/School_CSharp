using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace EssentialApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class URLPage : ContentPage
    {
        private string urlAdress;

        public string UrlAdress
        {
            get { return urlAdress; }
            set { urlAdress = value; }
        }


        public URLPage()
        {
            InitializeComponent();
        }

        private void ToURL_Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Browser.OpenAsync(UrlAdress, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception)
            {

                //throw;
            }
           
        }
    }
}