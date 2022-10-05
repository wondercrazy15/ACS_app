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
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.PopAsync(true);
        }
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new SignNoteView()));
        }

        [Obsolete]
        void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.PopAsync(true);
        }

        [Obsolete]
        void TapGestureRecognizer_Tapped_2(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.PushAsync(new RegisterPopup2());
        }

        [Obsolete]
        void TapGestureRecognizer_Tapped_as_register_a_team(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.PushAsync(new RegisterPopup3());
        }
        [Obsolete]
        void TapGestureRecognizer_Tapped_as_register_a_sponsor(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.PushAsync(new RegisterASponsorView());
        }
        [Obsolete]
        void TapGestureRecognizer_Tapped_as_register_a_hope_lodge(System.Object sender, System.EventArgs e)
        {
            PopupNavigation.PushAsync(new RegisterAHopeLodgeView());
        }
    }
}

