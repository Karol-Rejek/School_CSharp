﻿using LoginListApp.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginListApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListPage();
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
