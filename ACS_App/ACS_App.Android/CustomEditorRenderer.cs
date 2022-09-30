﻿using System;
using ACS_App.Droid;
using ACS_App.Helper;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace ACS_App.Droid
{
    public class CustomEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(Android.Graphics.Color.Transparent);
                this.Control.SetBackground(gd);
                this.Control.SetPadding(20, 20, 20, 20);
                EditText nativeEditText = this.Control;
                nativeEditText.SetTextCursorDrawable(Resource.Drawable.entry_cursor_color);
            }

        }
        public CustomEditorRenderer(Context context) : base(context)
        {

        }
    }
}

