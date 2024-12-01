using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            TabbedPage tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new FirstPage() { Title = "Pierwsza"});
            tabbedPage.Children.Add(new SecondPage() { Title = "Druga"});
            tabbedPage.Children.Add(new ThirdPage() { Title = "Trzecia"});

            TabbedPage secondTabedPage = new TabbedPage() { Title = "Zakładki"};
            secondTabedPage.Children.Add(new MainPage() { Title = "Główna" });
            secondTabedPage.Children.Add(new FirstPage() { Title = "Pierwsza 1" });

            tabbedPage.Children.Add(secondTabedPage);


            tabbedPage.Children.Add(new NavigationPage(new FirstPage() { Title = "Tytul" }) { Title = "Nawigacja" });

            MainPage = tabbedPage;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
