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
    [Activity(Label = "DerisiDikenlilerActivity")]
    public class DerisiDikenlilerActivity : Activity
    {
        Button btnDerisiDikenGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DerisiDikenliler);

            btnDerisiDikenGeri = FindViewById<Button>(Resource.Id.btnDerisiDikenGeri);

            btnDerisiDikenGeri.Click += (sender, e) => { StartActivity(typeof(OmurgasizlarActivity)); Finish(); };
            }
    }
}