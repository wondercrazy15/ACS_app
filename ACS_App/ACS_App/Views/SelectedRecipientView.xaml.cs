using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class SelectedRecipientView : ContentPage
    {
        List<string> Recipient_Age_group_listItems = new List<string>();
        public SelectedRecipientView()
        {
            InitializeComponent();
            string listItem = "Sam";
            string listItem1 = "Tanya";
            string listItem2 = "Kelly";
            string listItem3 = "Sam";
            string listItem4 = "Tanya";
            string listItem5 = "Kelly";
            string listItem8 = "Sam";
            string listItem6 = "Tanya";
            string listItem7 = "Kelly";

            Recipient_Age_group_listItems.Add(listItem);
            Recipient_Age_group_listItems.Add(listItem1);
            Recipient_Age_group_listItems.Add(listItem2);
            Recipient_Age_group_listItems.Add(listItem3);
            Recipient_Age_group_listItems.Add(listItem4);
            Recipient_Age_group_listItems.Add(listItem5);
            Recipient_Age_group_listItems.Add(listItem8);
            Recipient_Age_group_listItems.Add(listItem6);
            Recipient_Age_group_listItems.Add(listItem7);

            selectedRecipientList.ItemsSource = Recipient_Age_group_listItems;
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
        }
        void Recipient_Age_group_list_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Console.WriteLine("name" + e.CurrentSelection[0].ToString());
            Console.WriteLine("id"+e.CurrentSelection.Count.ToString());
        }
    }
}

