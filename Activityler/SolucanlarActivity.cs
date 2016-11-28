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
    [Activity(Label = "SolucanlarActivity")]
    public class SolucanlarActivity : Activity
    {
        Button btnSolucanGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Solucanlar);

            btnSolucanGeri = FindViewById<Button>(Resource.Id.btnSolucanlarGeri);

            btnSolucanGeri.Click += (sender, e) => { StartActivity(typeof(OmurgasizlarActivity)); Finish(); };

            }
    }
}