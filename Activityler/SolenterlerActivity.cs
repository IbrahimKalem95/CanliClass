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
    [Activity(Label = "SölenterlerActivity")]
    public class SolenterlerActivity : Activity
    {
        Button btnSölenterGeri;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Solenterler);

            btnSölenterGeri = FindViewById < Button >(Resource.Id.btnSölenterGeri);

            btnSölenterGeri.Click += (sender, e) => { StartActivity(typeof(OmurgasizlarActivity)); Finish(); };
            }
    }
}