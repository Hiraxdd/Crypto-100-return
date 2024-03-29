﻿using DniOtwarte.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DniOtwarte
{
    public partial class App : Application
    {
        public static IRestService RestApiService { get; private set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
            RestApiService = new RestService();
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
