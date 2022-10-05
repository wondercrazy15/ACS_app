using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class ShopSponsorship : ContentPage
    {
        public ShopSponsorship()
        {
            InitializeComponent();
            Sponsorship_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            Shop_2_frame.BackgroundColor = Color.White;
            SponsorshipStack.IsVisible = true;
            ShopStack.IsVisible = false;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = safeAreaInset;
        }

        void TapGestureRecognizer_Tapped_Right(System.Object sender, System.EventArgs e)
        {
            Shop_2_frame.BackgroundColor = Color.White;
            Sponsorship_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            ShopStack.IsVisible = false;
            SponsorshipStack.IsVisible = true;
            BarName.Text = "Shop sponsorship";
        }

        void TapGestureRecognizer_Tapped_left(System.Object sender, System.EventArgs e)
        {
            Shop_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            Sponsorship_2_frame.BackgroundColor = Color.White;
            ShopStack.IsVisible = true;
            SponsorshipStack.IsVisible = false;
            BarName.Text = "Shop";
        }
    }
}

