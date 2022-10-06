using System;
using System.Collections.Generic;
using System.Reflection;
using Android.Content.Res;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace ACS_App.Views
{
    public partial class LeaderboardView : ContentPage
    {
        public LeaderboardView()
        {
            InitializeComponent();

            Teams_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            Individuals_2_frame.BackgroundColor = Color.White;
            TeamsData.IsVisible = true;
            IndividualsData.IsVisible = false;

            List<ListClass> listItems = new List<ListClass>();
            listItems.Add(new ListClass { Index = 1, Name = "Kyereh Bismark", Points = "23,456", Colour = "#FFC107" });
            listItems.Add(new ListClass { Index = 2, Name = "Joseph Edusei", Points = "83,100", Colour = "#6FC0DA" });
            listItems.Add(new ListClass { Index = 3, Name = "Frank Odoom", Points = "6,125", Colour = "#DF7158" });
            listItems.Add(new ListClass { Index = 4, Name = "Gilbert Oppong", Points = "41,200", Colour = "#FFFFFF" });
            listItems.Add(new ListClass { Index = 5, Name = "Kyereh Bismark", Points = "72,000", Colour = "#FFFFFF" });
            listItems.Add(new ListClass { Index = 6, Name = "Kyereh Bismark", Points = "85,657", Colour = "#FFFFFF" });
            listItems.Add(new ListClass { Index = 7, Name = "Kyereh Bismark", Points = "36,487", Colour = "#FFFFFF" });
            listItems.Add(new ListClass { Index = 8, Name = "Kyereh Bismark", Points = "12,879", Colour = "#FFFFFF" });
            Name_list.ItemsSource = listItems;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            var safeAreaInset = On<Xamarin.Forms.PlatformConfiguration.iOS>().SafeAreaInsets();
            BgStack.Padding = new Thickness(0, safeAreaInset.Top, 0, 0);
        }

        //void backArrow(System.Object sender, System.EventArgs e)
        //{
        //    Navigation.PopModalAsync();
        //}

        void TapGestureRecognizer_Tapped_left(System.Object sender, System.EventArgs e)
        {
            Individuals_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            Teams_2_frame.BackgroundColor = Color.White;
            IndividualsData.IsVisible = true;
            TeamsData.IsVisible = false;
        }

        void TapGestureRecognizer_Tapped_Right(System.Object sender, System.EventArgs e)
        {
            Individuals_2_frame.BackgroundColor = Color.White;
            Teams_2_frame.BackgroundColor = Color.FromHex("#722BAD");
            IndividualsData.IsVisible = false;
            TeamsData.IsVisible = true;
        }

        void OnTapToCommunity(System.Object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new UsersView()));
        }
    }
    public class ListClass
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Points { get; set; }
        public string Colour { get; set; }
    }
}