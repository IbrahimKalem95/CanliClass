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
    [Activity(Label = "SürüngenlerActivity")]
    public class SurungenlerActivity : Activity
    {
        Button btnSurungenlerGeri;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Surungenler);

            btnSurungenlerGeri = FindViewById<Button>(Resource.Id.btnSurungenlerGeri);

            btnSurungenlerGeri.Click += (sender, e) => { StartActivity(typeof(OmurgalilarActivity)); Finish(); };
            
        }
    }
}