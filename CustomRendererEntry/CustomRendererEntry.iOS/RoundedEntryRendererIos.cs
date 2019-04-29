using CustomRendererEntry;
using CustomRendererEntry.iOS;
using CoreGraphics;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(RoundedEntryRendererIos))]
namespace CustomRendererEntry.iOS
{
    class RoundedEntryRendererIos : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Layer.CornerRadius = 20;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.DeepPink.ToCGColor();
                Control.Layer.BackgroundColor = Color.LightGray.ToCGColor();

                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;
            }
        }
    }
}
