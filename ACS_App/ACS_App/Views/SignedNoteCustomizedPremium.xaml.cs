using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace ACS_App.Views
{
    public partial class SignedNoteCustomizedPremium : ContentPage
    {
        private bool relationship_To_Cancer_IsVisible = false;
        List<string> relationship_To_Cancer_listItems = new List<string>();
        public SignedNoteCustomizedPremium()
        {
            InitializeComponent();
            string listItem1 = "Family member of cancer fighter";
            string listItem2 = "Fighter";
            string listItem3 = "Carer";
            string listItem4 = "Friend of ACS";
            string listItem5 = "Survivor";
            string listItem6 = "Author of love notes";

            relationship_To_Cancer_listItems.Add(listItem1);
            relationship_To_Cancer_listItems.Add(listItem2);
            relationship_To_Cancer_listItems.Add(listItem3);
            relationship_To_Cancer_listItems.Add(listItem4);
            relationship_To_Cancer_listItems.Add(listItem5);
            relationship_To_Cancer_listItems.Add(listItem6);

            relationship_to_cancer_frameView_list.ItemsSource = relationship_To_Cancer_listItems;
            relationship_to_cancer_frameView_list.HeightRequest = relationship_To_Cancer_listItems.Count * 22;
            relationship_to_cancer_frameView.IsVisible = false;
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
            Navigation.PushModalAsync(new NavigationPage(new CategorizeDetailDropdownView()));
        }
    }
}

