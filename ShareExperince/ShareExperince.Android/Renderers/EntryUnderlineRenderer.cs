using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ShareExperince.Droid.Renderers;
using ShareExperince.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.Opengl.GLSurfaceView;

[assembly: ExportRenderer(typeof(EntryBorderRenderer), typeof(EntryUnderlineRenderer))]
namespace ShareExperince.Droid.Renderers
{
    class EntryUnderlineRenderer: EntryRenderer
    {
        public EntryUnderlineRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}