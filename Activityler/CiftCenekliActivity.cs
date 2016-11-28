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
    [Activity(Label = "CiftCenekliActivity")]
    public class CiftCenekliActivity : Activity
    {
        Button btnCiftCenekilGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.CiftCenekli);

            btnCiftCenekilGeri = FindViewById<Button>(Resource.Id.btnCiftCenekliGeri);

            btnCiftCenekilGeri.Click += (sender, e) => { StartActivity(typeof(KapaliTohumluActivity)); Finish(); };
        }
    }
}