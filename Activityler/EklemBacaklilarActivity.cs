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
    [Activity(Label = "EklemBacaklılarActivity")]
    public class EklemBacaklilarActivity : Activity
    {
        Button btnEklelilerGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.EklemBacaklilar);
            
            btnEklelilerGeri = FindViewById<Button>(Resource.Id.btnEklemlilerGeri);

            btnEklelilerGeri.Click += (sender, e) => { StartActivity(typeof(OmurgasizlarActivity)); Finish(); };
            }
    }
}