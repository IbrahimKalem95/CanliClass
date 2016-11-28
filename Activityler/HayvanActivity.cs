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
    [Activity(Label = "HayvanActivity")]
    public class HayvanActivity : Activity
    {
        Button btnOmurgalilar;
        Button btnOmurgasýzlar;
        Button btnbasitHayvanlar;
        Button btnGeriHayvanlar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Hayvan);

            //buttonlarýn cagýrýlmasý
            btnbasitHayvanlar = FindViewById<Button>(Resource.Id.btnBasitHayvan);
            btnOmurgalilar = FindViewById<Button>(Resource.Id.btnOmurgalý);
            btnOmurgasýzlar = FindViewById<Button>(Resource.Id.btnOmurgasýz);
            btnGeriHayvanlar = FindViewById<Button>(Resource.Id.btnGeriHayvan);

            //Button clickleri
            btnOmurgasýzlar.Click += (sender, e) => { StartActivity(typeof(OmurgasizlarActivity)); Finish(); };
            btnOmurgalilar.Click += (sender, e) => { StartActivity(typeof(OmurgalilarActivity)); Finish(); };
            btnbasitHayvanlar.Click += (sender, e) => { StartActivity(typeof(BasitHayvanlarActivity)); Finish(); };
            btnGeriHayvanlar.Click += (sender, e) => { StartActivity(typeof(MainActivity)); Finish(); };
                }
    }
}