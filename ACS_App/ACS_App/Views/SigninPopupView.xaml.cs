using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ACS_App.Views
{
    public partial class SigninPopupView : PopupPage
    {
        public SigninPopupView()
        {
            InitializeComponent();
        }

        void btn_icon_password_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        [Obsolete]
        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            try
            {
                await PopupNavigation.PopAsync();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}

