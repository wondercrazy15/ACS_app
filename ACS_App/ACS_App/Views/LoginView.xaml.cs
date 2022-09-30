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

        [Obsolete]
        async void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                await PopupNavigation.PushAsync(new RegisterPopup1());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

