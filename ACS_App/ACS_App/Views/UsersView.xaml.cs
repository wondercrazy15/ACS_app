using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class UsersView : ContentPage
    {
        public UsersView()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var dwidth = DeviceDisplay.MainDisplayInfo.Width;
            //var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            //var orientation = mainDisplayInfo.Orientation;
            FirstlableWidth.WidthRequest = dwidth * 0.25;
            SecondlableWidth.WidthRequest = dwidth * 0.25;
            ThirdlableWidth.WidthRequest = dwidth * 0.25;
            FourlableWidth.WidthRequest = dwidth * 0.25;
            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = new Thickness(0, safeAreaInset.Top, 0, 0);
            bgStackBottom.Padding = new Thickness(0, 0, 0, safeAreaInset.Bottom);
        }

        void CompetitionTab(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new LeaderboardView()));
        }
    }
}