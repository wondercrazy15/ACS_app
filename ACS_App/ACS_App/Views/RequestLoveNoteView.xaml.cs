using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace ACS_App.Views
{
    public partial class RequestLoveNoteView : ContentPage
    {
        private bool CategorizeIsVisible = false , Recipient_GenderIsVisible = false, form_of_deleveryIsVisible = false;
        List<string> Recipient_Age_group_listItems = new List<string>();
        List<string> Recipient_Gender_listItems = new List<string>();
        List<string> Form_Of_Delevery_listItems = new List<string>();
        public RequestLoveNoteView()
        {
            InitializeComponent();

            string listItem = "Senior";
            string listItem1 = "General";
            string listItem2 = "Child";
            string listItem3 = "Young Adult";

            Recipient_Age_group_listItems.Add(listItem);
            Recipient_Age_group_listItems.Add(listItem1);
            Recipient_Age_group_listItems.Add(listItem2);
            Recipient_Age_group_listItems.Add(listItem3);

            Recipient_Age_group_list.ItemsSource = Recipient_Age_group_listItems;
            Recipient_Age_group_list.HeightRequest = Recipient_Age_group_listItems.Count * 22;
            Recipient_Age_group_frameView.IsVisible = false;

            string listItem4 = "Female";
            string listItem5 = "None";
            string listItem6 = "Male";

            Recipient_Gender_listItems.Add(listItem4);
            Recipient_Gender_listItems.Add(listItem5);
            Recipient_Gender_listItems.Add(listItem6);

            Recipient_Gender_list.ItemsSource = Recipient_Gender_listItems;
            Recipient_Gender_list.HeightRequest = Recipient_Gender_listItems.Count * 22;
            Recipient_Gender_frameView.IsVisible = false;

            string listItem7 = "Text (USA only)";
            string listItem8 = "Whatsapp";
            string listItem9 = "Email";

            Form_Of_Delevery_listItems.Add(listItem7);
            Form_Of_Delevery_listItems.Add(listItem8);
            Form_Of_Delevery_listItems.Add(listItem9);

            form_of_delivery_frameView_list.ItemsSource = Form_Of_Delevery_listItems;
            form_of_delivery_frameView_list.HeightRequest = Form_Of_Delevery_listItems.Count * 22;
            form_of_delivery_frameView.IsVisible = false;
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
                Cateforize_by_age_image.Source = "arrow_drop_down_circle";
            }
            else
            {
                Recipient_Age_group_frameView.IsVisible = true;
                CategorizeIsVisible = true;
                Cateforize_by_age_image.Source = "arrow_drop_up_circle";
            }
        }
        void Recipient_Age_group_list_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.CurrentSelection[0].ToString());
            Cateforize_by_age_text.Text = e.CurrentSelection[0].ToString();
            Recipient_Age_group_frameView.IsVisible = false;
            CategorizeIsVisible = false;
            Cateforize_by_age_image.Source = "arrow_drop_down_circle";
        }

        void btn_icon_Recipient_Gender_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Recipient_GenderIsVisible)
            {
                Recipient_Gender_frameView.IsVisible = false;
                Recipient_GenderIsVisible = false;
                Cateforize_by_Gender_image.Source = "arrow_drop_down_circle";
            }
            else
            {
                Recipient_Gender_frameView.IsVisible = true; 
                Recipient_GenderIsVisible = true;
                Cateforize_by_Gender_image.Source = "arrow_drop_up_circle";
            }
        }
        void Recipient_Gender_group_list_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.CurrentSelection[0].ToString());
            Cateforize_by_Gender_text.Text = e.CurrentSelection[0].ToString();
            Recipient_Gender_frameView.IsVisible = false;
            Recipient_GenderIsVisible = false;
            Cateforize_by_Gender_image.Source = "arrow_drop_down_circle";
        }

        void btn_icon_form_of_delivery_Clicked(System.Object sender, System.EventArgs e)
        {
            if (form_of_deleveryIsVisible)
            {
                form_of_delivery_frameView.IsVisible = false;
                form_of_deleveryIsVisible = false;
                form_of_delivery_image.Source = "arrow_drop_down_circle";
            }
            else
            {
                form_of_delivery_frameView.IsVisible = true;
                form_of_deleveryIsVisible = true;
                form_of_delivery_image.Source = "arrow_drop_up_circle";
            }
        }
        void form_of_delivery_group_list_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.CurrentSelection[0].ToString());
            form_of_delivery_text.Text = e.CurrentSelection[0].ToString();
            form_of_delivery_frameView.IsVisible = false;
            form_of_delivery_image.Source = "arrow_drop_down_circle";
            form_of_deleveryIsVisible = false;
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new RequestLoveNoteImageUploadView()));
        }
    }
}