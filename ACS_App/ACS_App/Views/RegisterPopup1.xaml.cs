using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ACS_App.Views
{
    public partial class RegisterPopup1 : PopupPage
    {
        public RegisterPopup1()
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

        [Obsolete]
        async void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.PushAsync(new RegisterPopup2());
        }
    }
}

