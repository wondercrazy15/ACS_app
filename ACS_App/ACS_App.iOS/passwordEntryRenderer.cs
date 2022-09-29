using System;
using ACS_App.Helper;
using ACS_App.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(PasswordCustomRendererEntry), typeof(passwordEntryRenderer))]
namespace ACS_App.iOS
{
    public class passwordEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            Control.TintColor = UIColor.Purple;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}

