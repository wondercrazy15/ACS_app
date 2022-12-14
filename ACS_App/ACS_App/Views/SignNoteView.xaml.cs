using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace ACS_App.Views
{
    public partial class SignNoteView : ContentPage
    {
        public SignNoteView()
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
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new SignedNoteCustomizedPremium()));
        //void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        //{
        //    Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new personilizeWithImage()));
        }
    }
}

