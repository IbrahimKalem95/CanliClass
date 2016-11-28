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
    [Activity(Label = "KurbagalarActivity")]
    public class KurbagalarActivity : Activity
    {
        Button btnKurbagalarGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Kurbagalar);

            btnKurbagalarGeri = FindViewById<Button>(Resource.Id.btnKurbagalarGeri);

            btnKurbagalarGeri.Click += (sender, e) => { StartActivity(typeof(OmurgalilarActivity)); Finish(); };
            }
    }
}