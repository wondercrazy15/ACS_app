using System;
using ACS_App.Droid;
using ACS_App.Helper;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(PasswordCustomRendererEntry), typeof(passwordEntryRenderer))]
namespace ACS_App.Droid
{
    public class passwordEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            this.Control.Background = null;
            this.Control.SetPadding(0,0,0,0);
            EditText nativeEditText = this.Control;
            nativeEditText.SetTextCursorDrawable(Resource.Drawable.entry_cursor_color);
        }

        public passwordEntryRenderer(Context context) : base(context)
        {

        }
    }
}

