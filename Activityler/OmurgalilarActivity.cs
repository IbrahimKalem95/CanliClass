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
    [Activity(Label = "OmurgalılarActivity")]
    public class OmurgalilarActivity : Activity
    {
        Button btnBaliklar;
        Button btnKurbagalar;
        Button btnSurungenler;
        Button btnKuslar;
        Button btnMemeliler;
        Button btnOmurgalilarGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Omurgalilar);

            //Buttonların cagılrılması 
            btnBaliklar = FindViewById<Button>(Resource.Id.btnBalik);
            btnKurbagalar = FindViewById<Button>(Resource.Id.btnKurbaga);
            btnSurungenler = FindViewById<Button>(Resource.Id.btnSurungen);
            btnKuslar = FindViewById<Button>(Resource.Id.btnKuslar);
            btnMemeliler = FindViewById<Button>(Resource.Id.btnMemeli);
            btnOmurgalilarGeri = FindViewById<Button>(Resource.Id.btnOmurgaliGeri);

            //button Clickleri
            btnBaliklar.Click += (sender, e) => { StartActivity(typeof(BaliklarActivity)); Finish(); };
            btnKurbagalar.Click += (sender, e) => { StartActivity(typeof(KurbagalarActivity)); Finish(); };
            btnSurungenler.Click += (sender, e) => { StartActivity(typeof(SurungenlerActivity)); Finish(); };
            btnKuslar.Click += (sender, e) => { StartActivity(typeof(KuslarActivity)); Finish(); };
            btnMemeliler.Click += (sender, e) => { StartActivity(typeof(MemelilerActivity)); Finish(); Finish(); };
            btnOmurgalilarGeri.Click += (sender, e) => { StartActivity(typeof(HayvanActivity)); Finish(); };


                                }
    }
}