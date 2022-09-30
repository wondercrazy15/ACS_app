using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using static Android.App.LauncherActivity;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace ACS_App.Views
{
    public partial class CategorizeDetailDropdownView : ContentPage
    {        
        private bool relationship_To_Cancer_IsVisible = false, Recipient_GenderIsVisible = false, CategorizeIsVisible = false;
        List<string> Recipient_Age_group_listItems = new List<string>();
        List<string> Recipient_Gender_listItems = new List<string>();
        List<string> relationship_To_Cancer_listItems = new List<string>();
        public CategorizeDetailDropdownView()
        {
            InitializeComponent();
            string listItem1 = "Family member of cancer fighter";
            string listItem2 = "Fighter";
            string listItem3 = "Carer";
            string listItem4 = "Friend of ACS";
            string listItem5 = "Survivor";
            string listItem6 = "General Love Note";

            relationship_To_Cancer_listItems.Add(listItem1);
            relationship_To_Cancer_listItems.Add(listItem2);
            relationship_To_Cancer_listItems.Add(listItem3);
            relationship_To_Cancer_listItems.Add(listItem4);
            relationship_To_Cancer_listItems.Add(listItem5);
            relationship_To_Cancer_listItems.Add(listItem6);

            relationship_to_cancer_frameView_list.ItemsSource = relationship_To_Cancer_listItems;
            relationship_to_cancer_frameView_list.HeightRequest = relationship_To_Cancer_listItems.Count * 22;
            relationship_to_cancer_frameView.IsVisible = false;

            string listItem7 = "Senior";
            string listItem8 = "General";
            string listItem9 = "Child";
            string listItem10 = "Young Adult";

            Recipient_Age_group_listItems.Add(listItem7);
            Recipient_Age_group_listItems.Add(listItem8);
            Recipient_Age_group_listItems.Add(listItem9);
            Recipient_Age_group_listItems.Add(listItem10);

            Recipient_Age_group_list.ItemsSource = Recipient_Age_group_listItems;
            Recipient_Age_group_list.HeightRequest = Recipient_Age_group_listItems.Count * 22;
            Recipient_Age_group_frameView.IsVisible = false;

            string listItem11 = "Female";
            string listItem12 = "None";
            string listItem13 = "Male";

            Recipient_Gender_listItems.Add(listItem11);
            Recipient_Gender_listItems.Add(listItem12);
            Recipient_Gender_listItems.Add(listItem13);

            Recipient_Gender_list.ItemsSource = Recipient_Gender_listItems;
            Recipient_Gender_list.HeightRequest = Recipient_Gender_listItems.Count * 22;
            Recipient_Gender_frameView.IsVisible = false;

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
        void btn_icon_recipientAge_Clicked(System.Object sender, System.EventArgs e)
        {
            if (CategorizeIsVisible)
            {
                Recipient_Age_group_frameView.IsVisible = false;
                CategorizeIsVisible = false;
                Categorize_by_age_image.Source = "arrow_drop_down_circle";
            }
            else
            {
                Recipient_Age_group_frameView.IsVisible = true;
                CategorizeIsVisible = true;
                Categorize_by_age_image.Source = "arrow_drop_up_circle";
            }
        }
        void Recipient_Age_group_list_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.CurrentSelection[0].ToString());
            Categorize_by_age_text.Text = e.CurrentSelection[0].ToString();
            Recipient_Age_group_frameView.IsVisible = false;
            CategorizeIsVisible = false;
            Categorize_by_age_image.Source = "arrow_drop_down_circle";
        }

        void btn_icon_Recipient_Gender_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Recipient_GenderIsVisible)
            {
                Recipient_Gender_frameView.IsVisible = false;
                Recipient_GenderIsVisible = false;
                Categorize_by_Gender_image.Source = "arrow_drop_down_circle";
            }
            else
            {
                Recipient_Gender_frameView.IsVisible = true;
                Recipient_GenderIsVisible = true;
                Categorize_by_Gender_image.Source = "arrow_drop_up_circle";
            }
        }
        void Recipient_Gender_group_list_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.CurrentSelection[0].ToString());
            Categorize_by_Gender_text.Text = e.CurrentSelection[0].ToString();
            Recipient_Gender_frameView.IsVisible = false;
            Recipient_GenderIsVisible = false;
            Categorize_by_Gender_image.Source = "arrow_drop_down_circle";
        }

        void form_of_delivery_group_list_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.CurrentSelection[0].ToString());
            relationship_to_cancer_text.Text = e.CurrentSelection[0].ToString();
            relationship_to_cancer_frameView.IsVisible = false;
            relationship_to_cancer_image.Source = "arrow_drop_down_circle";
            relationship_To_Cancer_IsVisible = false;
        }
        void btn_icon_form_of_delivery_Clicked(System.Object sender, System.EventArgs e)
        {
            if (relationship_To_Cancer_IsVisible)
            {
                relationship_to_cancer_frameView.IsVisible = false;
                relationship_To_Cancer_IsVisible = false;
                relationship_to_cancer_image.Source = "arrow_drop_down_circle";
            }
            else
            {
                relationship_to_cancer_frameView.IsVisible = true;
                relationship_To_Cancer_IsVisible = true;
                relationship_to_cancer_image.Source = "arrow_drop_up_circle";
            }
        }
        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new StripePaymentView()));
        }
    }
}

