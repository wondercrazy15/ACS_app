using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class LeaderboardView : ContentPage
    {
        //List<string> TeamList = new List<string>();
        public LeaderboardView()
        {
            InitializeComponent();
            //string listItem1 = "Gilbert Oppong";
            //string listItem2 = "Joseph Edusei";
            //string listItem3 = "Frank Odoom";
            //string listItem4 = "Kyereh Bismark";

            //TeamList.Add(listItem1);
            //TeamList.Add(listItem2);
            //TeamList.Add(listItem3);
            //TeamList.Add(listItem4);
            //TeamList.Add(listItem4);
            //TeamList.Add(listItem4);
            //TeamList.Add(listItem4);
            //TeamList.Add(listItem4);

            //Name_list.ItemsSource = TeamList;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = new Thickness(0, safeAreaInset.Top, 0, 0);

            List<ListClass> listItems = new List<ListClass>();
            listItems.Add(new ListClass { Index = 1 , Name = "Gilbert Oppong", Points = 123456});
            listItems.Add(new ListClass { Index = 2, Name = "Joseph Edusei", Points = 85178 });
            listItems.Add(new ListClass { Index = 3, Name = "Frank Odoom", Points = 25987 });
            listItems.Add(new ListClass { Index = 4, Name = "Kyereh Bismark", Points = 41200 });
            listItems.Add(new ListClass { Index = 5, Name = "Kyereh Bismark", Points = 72000 });
            listItems.Add(new ListClass { Index = 6, Name = "Kyereh Bismark", Points = 85657 });
            listItems.Add(new ListClass { Index = 7, Name = "Kyereh Bismark", Points = 36487 });
            listItems.Add(new ListClass { Index = 8, Name = "Kyereh Bismark", Points = 12879 });
            Name_list.ItemsSource = listItems;
        }

        void backArrow(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void TapGestureRecognizer_Tapped_left(System.Object sender, System.EventArgs e)
        {
            Individuals_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            Teams_2_frame.BackgroundColor = Color.White;
            //myPageStack.IsVisible = true;
            //myBadgesStack.IsVisible = false;
        }

        void TapGestureRecognizer_Tapped_Right(System.Object sender, System.EventArgs e)
        {
            Individuals_2_frame.BackgroundColor = Color.White;
            Teams_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            //myPageStack.IsVisible = false;
            //myBadgesStack.IsVisible = true;
        }
    }
    public class ListClass
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}