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
    [Activity(Label = "TekCenekliActivity")]
    public class TekCenekliActivity : Activity
    {
        Button btnTekCenekilGeri;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.TekCenekli);

            btnTekCenekilGeri = FindViewById<Button>(Resource.Id.btnTekCenekliGeri);

            btnTekCenekilGeri.Click += (sender, e) => { StartActivity(typeof(KapaliTohumluActivity)); Finish(); };
            }
    }
}