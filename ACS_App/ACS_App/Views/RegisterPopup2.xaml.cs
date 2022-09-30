using System;
using System.Collections.Generic;
//using Android.Content.Res;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ACS_App.Views
{
    public partial class RegisterPopup2 : PopupPage
    {
        public RegisterPopup2()
        {
            InitializeComponent();
        }
        [Obsolete]
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.PopAsync(true);
        }
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new SignNoteView()));
        }

        [Obsolete]
        async void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.PopAsync(true);
        }

        void btn_icon_password_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}

