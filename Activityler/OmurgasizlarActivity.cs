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
    [Activity(Label = "OmurgasizlarActivity")]
    public class OmurgasizlarActivity : Activity
    {
        Button btnSungerler;
        Button btnSolenterler;
        Button btnSolucanlar;
        Button btnYumusakcalar;
        Button btnEklemBcaklýlar;
        Button btnDerisiDikenliler;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Omurgasizlar);

            //Buttonlarýn cagýlrýlmasý 
            btnSungerler = FindViewById<Button>(Resource.Id.btnSunger);
            btnSolenterler = FindViewById<Button>(Resource.Id.btnSolenter);
            btnSolucanlar = FindViewById<Button>(Resource.Id.btnSolucan);
            btnYumusakcalar = FindViewById<Button>(Resource.Id.btnYumusakca);
            btnEklemBcaklýlar = FindViewById<Button>(Resource.Id.btnEklemBacakli);
            btnDerisiDikenliler = FindViewById<Button>(Resource.Id.btnDerisiDikenli);

            //button Clickleri
            btnSungerler.Click += (sender, e) => { StartActivity(typeof(SungerlerActivity)); Finish(); };
            btnSolenterler.Click += (sender, e) => { StartActivity(typeof(SolenterlerActivity)); Finish(); };
            btnSolucanlar.Click += (sender, e) => { StartActivity(typeof(SolucanlarActivity)); Finish(); };
            btnYumusakcalar.Click += (sender, e) => { StartActivity(typeof(YumusakcalarActivity)); Finish(); };
            btnEklemBcaklýlar.Click += (sender, e) => { StartActivity(typeof(EklemBacaklilarActivity)); Finish(); };
            btnDerisiDikenliler.Click += (sender, e) => { StartActivity(typeof(DerisiDikenlilerActivity)); Finish(); };


                                }
    }
}