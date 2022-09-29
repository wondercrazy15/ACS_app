
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ACS_App.Droid
{
    //[Activity(Label = "SpalshActivity")]
    [Activity(Label = "ACS App", Icon = "@mipmap/icon", Theme = "@style/SplashStyle", MainLauncher = true, NoHistory = true)]
    public class SpalshActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(2000);
            StartActivity(typeof(MainActivity));
            // Create your application here
        }
    }
}