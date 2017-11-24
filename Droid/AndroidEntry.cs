using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CustomRenderer;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(SampleCustomRenderer.Droid.AndroidEntry))]
namespace SampleCustomRenderer.Droid
{
    public class AndroidEntry: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
            }
        }
    }
}
