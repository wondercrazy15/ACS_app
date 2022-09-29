using System;
using System.Collections.Generic;
using NavigationPage = Xamarin.Forms.NavigationPage;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class SignUpMenuTab_First_View : ContentPage
    {
        public SignUpMenuTab_First_View()
        {
            InitializeComponent();
            List<string> listItems = new List<string>();
            string listItem = "gr";
            string listItem1 = "gr";
            string listItem2 = "gr";
            listItems.Add(listItem);  
            listItems.Add(listItem1);  
            listItems.Add(listItem2);  
            collectionList.ItemsSource = listItems; 
            
        }

        void backArrow(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = new Thickness(0, safeAreaInset.Top, 0, 0);
            bgStackBottom.Padding = new Thickness(0, 0, 0, safeAreaInset.Bottom);
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new CustomizeNoteView()));
        }

        void TapGestureRecognizer_Tapped_sendvideolove(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new VideoNoteView()));
        }
    }
}

