using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class personilizeWithImage : ContentPage
    {
        public personilizeWithImage()
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
            try
            {
                Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new RecipientInformationView()));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

