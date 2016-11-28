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
    [Activity(Label = "BaliklarActivity")]
    public class BaliklarActivity : Activity
    {
        Button btnGeriBalik;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Baliklar);

            btnGeriBalik = FindViewById<Button>(Resource.Id.btnBalikGeri);

            btnGeriBalik.Click += (sender, e) => { StartActivity(typeof(OmurgalilarActivity)); Finish(); };  
        }
    }
}