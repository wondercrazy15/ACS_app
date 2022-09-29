using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace ACS_App.Views
{
    public partial class HomePageView : ContentPage
    {
        public HomePageView()
        {
            InitializeComponent();
            //var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            //BgStack.Padding = safeAreaInset;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = safeAreaInset;
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new SignUpMenuTab_First_View()));
        }
       
        void TapGestureRecognizer_Tapped_collection(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new CollectLoveNoteMenu()));
        }

        void TapGestureRecognizer_Tapped_Reqest_Love_Note(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new RequestLoveNoteView()));
        }

        void Login_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new LoginView()));
        }
    }
}

