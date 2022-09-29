using System;
using ACS_App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ACS_App
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new customTabView();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

