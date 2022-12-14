using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class RecipientInformationView : ContentPage
    {
        public RecipientInformationView()
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
        void RadioButton_CheckedChanged(System.Object sender, Xamarin.Forms.CheckedChangedEventArgs e)
        {
            RadioButton button = sender as RadioButton;
            if (button.IsChecked == true)
            {
                Console.WriteLine(button.IsChecked.ToString());
                Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new SelectedRecipientView()));
            }
        }
    }
}

