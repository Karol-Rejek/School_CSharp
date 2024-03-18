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
    public partial class RegistrationPage : ContentPage
    {
        private string userLogin;

        public string UserLogin
        {
            get { return userLogin; }
            set { userLogin = value; }
        }

        private string userPassword;

        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        private string userRepeatedPassword;

        public string UserRepeatedPassword
        {
            get { return userRepeatedPassword; }
            set { userRepeatedPassword = value; }
        }

        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Registration(object sender, EventArgs e)
        {
            if (UserLogin != null /* && UserLogin != UserFromData*/)
            {
                if (UserPassword == UserRepeatedPassword)
                {
                    Navigation.PopAsync();
                }
            }
        }
    }
}