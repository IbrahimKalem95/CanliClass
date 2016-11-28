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
    [Activity(Label = "KapaliTohumluActivity")]
    public class KapaliTohumluActivity : Activity
    {
        Button btnTekCenekli;
        Button btnCiftCenekli;
        Button btnKapalýTohumluGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KapaliTohumlu);

            //buttonlarýn cagýrýlmasý
            btnTekCenekli = FindViewById<Button>(Resource.Id.btnTekCenek);
            btnCiftCenekli = FindViewById<Button>(Resource.Id.btnCiftCenek);
            btnKapalýTohumluGeri = FindViewById<Button>(Resource.Id.btnKapaliTohumluGeri);

            //button clickleri
            btnTekCenekli.Click += (sender, e) => { StartActivity(typeof(TekCenekliActivity)); Finish(); };
            btnCiftCenekli.Click += (sender, e) => { StartActivity(typeof(CiftCenekliActivity)); Finish(); };
            btnKapalýTohumluGeri.Click += (sender, e) => { StartActivity(typeof(CicekliActivity)); Finish(); };
                }
    }
}