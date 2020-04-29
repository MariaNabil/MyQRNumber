using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using QRGenerator;
using QRGenerator.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(XEntry), typeof(XEntryRenderer))]
namespace QRGenerator.Droid
{
    public class XEntryRenderer : EntryRenderer
    {
       // private UILabel _placeholderLabel;

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                
                //Control.SetBackgroundResource(Resource.Drawable.icon);
                Control.Gravity = GravityFlags.CenterVertical;
                TextAlignment = Android.Views.TextAlignment.Center;
                Control.TextAlignment = Android.Views.TextAlignment.Center;
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
                //Control.lin
                Control.SetCompoundDrawablesWithIntrinsicBounds(Control.Left, Control.Top, Control.Right, Control.Bottom);

                /*var _placeholderLabel = typeof(EntryRenderer).GetField("_placeholderLabel", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(this) ;
                _placeholderLabel.tr = true;
                _placeholderLabel.Bounds = Control.Bounds;
                _placeholderLabel.Frame = Control.Frame;
                _placeholderLabel.LineBreakMode = UILineBreakMode.WordWrap;
                _placeholderLabel.TextAlignment = UITextAlignment.Left;
                _placeholderLabel.Lines = 0;
                _placeholderLabel.SizeToFit();
                _placeholderLabel.SetNeedsDisplay();*/
                //var device = Resolver.Resolve();
                // DisplayMetrics displayMetrics = new DisplayMetrics();
                // WindowManager.DefaultDisplay.GetRealMetrics(displayMetrics);
                //var width = displayMetrics.WidthPixels;
                //Xamarin.Forms.Application.Current.MainPage.Width;
                //Control.SetMaxWidth(Convert.ToInt32( width) );
                var w = Resources.DisplayMetrics.WidthPixels;
                //Control.SetWidth (Convert.ToInt32(w)-100);
                int dp = 160;

                int pixel = (int)TypedValue.ApplyDimension(ComplexUnitType.Dip, dp, Context.Resources.DisplayMetrics);

                //int pixel = (int)System.Math.Round(dp * (displayMetrics.Xdpi / (float)DisplayMetrics.DensityDefault));
                Control.SetMaxWidth(w- pixel);

                Control.Gravity = GravityFlags.CenterHorizontal;


                IntPtr IntPtrtextViewClass = JNIEnv.FindClass(typeof(TextView));
                IntPtr mCursorDrawableResProperty = JNIEnv.GetFieldID(IntPtrtextViewClass, "mCursorDrawableRes", "I");
                JNIEnv.SetField(Control.Handle, mCursorDrawableResProperty, Resource.Drawable.cursor); // replace 0 with a Resource.Drawable.my_cursor

                

            }
        }
    }
}