using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using JobSearch.Droid.Utility.Controls;

[assembly: ExportRenderer(typeof(Entry),typeof(CustomEntryRender))]
namespace JobSearch.Droid.Utility.Controls
{
    public class CustomEntryRender : EntryRenderer
    {
        public CustomEntryRender(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.Background = null;
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}