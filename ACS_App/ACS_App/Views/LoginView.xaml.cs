using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;

namespace ACS_App.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        void btn_icon_password_Clicked(System.Object sender, System.EventArgs e)
        {
            
        }        

        [Obsolete]
        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await PopupNavigation.PushAsync(new SigninPopupView());
        }

        void Forgot_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new ForgotPasswordView()));
        }
    }
}

