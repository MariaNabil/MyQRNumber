using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using QRGenerator;
using QRGenerator.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(XEntry), typeof(XEntryRenderer))]
namespace QRGenerator.iOS
{
    public class XEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                //Control.SetBackgroundResource(Resource.Drawable.icon);

                //Control.Background == UIImage
                    //ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}