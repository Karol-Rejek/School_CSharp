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
    public partial class LoginPage : ContentPage
    {
        private  string userLogin;

        public  string UserLogin
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

        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked_Log(object sender, EventArgs e)
        {
            //if(UserLogin == LoginFormData && UserPassword == PasswordFromData)
            //{
            //    Navigation.PushAsync(new MainPage());   
            //}
        }

        private void Button_Clicked_Registration(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegistrationPage());
        }
    }
}