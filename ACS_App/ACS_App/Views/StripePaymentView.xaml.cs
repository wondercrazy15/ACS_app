﻿using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class StripePaymentView : ContentPage
    {
        public StripePaymentView()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = new Thickness(0, safeAreaInset.Top, 0, 0);
            bgStackBottom.Padding = new Thickness(0, 0, 0, safeAreaInset.Bottom);
        }
        void backArrow(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }        
    }
}

