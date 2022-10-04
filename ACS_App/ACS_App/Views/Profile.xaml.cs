using System;
using System.Collections;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class Profile : ContentPage
    {
        public Profile()
        {
            InitializeComponent();
            mypage_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            mybadges_2_frame.BackgroundColor = Color.White;
            myPageStack.IsVisible = true;
            myBadgesStack.IsVisible = false;
            //mypage_2_frame.BackgroundColor = Color.White;
            //mybadges_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            //myPageStack.IsVisible = false;
            //myBadgesStack.IsVisible = true;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = safeAreaInset;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new SettingsView()));
        }

        void TapGestureRecognizer_Tapped_left(System.Object sender, System.EventArgs e)
        {
            mypage_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            mybadges_2_frame.BackgroundColor = Color.White;
            myPageStack.IsVisible = true;
            myBadgesStack.IsVisible = false;

        }

        void TapGestureRecognizer_Tapped_Right(System.Object sender, System.EventArgs e)
        {
            mypage_2_frame.BackgroundColor = Color.White;
            mybadges_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            myPageStack.IsVisible = false;
            myBadgesStack.IsVisible = true;
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new FUNdraiseView()));
        }
    }
}

