﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using grand_duc_go.Services;
using grand_duc_go.Views;

namespace grand_duc_go
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new ItemsPage());
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
