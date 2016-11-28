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
    [Activity(Label = "YumusakcalarActivity")]
    public class YumusakcalarActivity : Activity
    {
        Button btnYumusakcaGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Yumusakcalar);

            btnYumusakcaGeri = FindViewById<Button>(Resource.Id.btnYumusakcaGeri);

            btnYumusakcaGeri.Click += (sender, e) => { StartActivity(typeof(OmurgasizlarActivity)); Finish(); };
            }
    }
}