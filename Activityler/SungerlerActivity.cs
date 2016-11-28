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
    [Activity(Label = "SüngerlerActivity")]
    public class SungerlerActivity : Activity
    {
        Button btnSüngerGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Sungerler);

            btnSüngerGeri = FindViewById<Button>(Resource.Id.btnSungerlerGeri);

            btnSüngerGeri.Click += (sender, e) => { StartActivity(typeof(OmurgasizlarActivity)); Finish(); };
            }
    }
}