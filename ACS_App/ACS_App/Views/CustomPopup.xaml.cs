using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ACS_App.Views
{
    public partial class CustomPopup : PopupPage
    {
        public CustomPopup()
        {
            InitializeComponent();
        }

        [Obsolete]
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.PopAsync(true);
        }       
    }
}

