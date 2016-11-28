using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CanliClass.Activityler
{
    [Activity(Label = "MemelilerActivity")]
    public class MemelilerActivity : Activity
    {
        Button btnMemelilerGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Memeliler);

            btnMemelilerGeri = FindViewById<Button>(Resource.Id.btnMemelilerGeri);

            btnMemelilerGeri.Click += (sender, e) => { StartActivity(typeof(OmurgalilarActivity)); Finish(); };
            }
    }
}