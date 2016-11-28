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
    [Activity(Label = "BitkiActivity")]
    public class BitkiActivity : Activity
    {
        Button btnCicekli;
        Button btnCiceksiz;
        Button btnBitkiGeri;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Bitki);


            //buttonlarýn cagýrýlmasý
            btnCiceksiz = FindViewById<Button>(Resource.Id.btnCiceksiz);
            btnCicekli = FindViewById<Button>(Resource.Id.btnCicekli);
            btnBitkiGeri = FindViewById<Button>(Resource.Id.btnGeriBitki);

            //button clickleri
            btnBitkiGeri.Click += (sender, e) => { StartActivity(typeof(MainActivity)); Finish(); };
            btnCicekli.Click += (sender, e) => { StartActivity(typeof(CicekliActivity)); Finish(); };
            btnCiceksiz.Click += (sender, e) =>{ StartActivity(typeof(CiceksizActivity)); Finish(); };
            
               
           
        }
    }
}