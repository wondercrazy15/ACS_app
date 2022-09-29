using System;
using ACS_App.Droid;
using ACS_App.Helper;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomRadioButton), typeof(CustomRadioRendere))]
namespace ACS_App.Droid
{
    public class CustomRadioRendere : RadioButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.RadioButton> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.ButtonTintList = ColorStateList.ValueOf(Android.Graphics.Color.Purple);
            }
        }
        public CustomRadioRendere(Context context) : base(context)
        {

        }
    }
}