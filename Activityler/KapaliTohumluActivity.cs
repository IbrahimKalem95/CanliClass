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
        Button btnKapal�TohumluGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.KapaliTohumlu);

            //buttonlar�n cag�r�lmas�
            btnTekCenekli = FindViewById<Button>(Resource.Id.btnTekCenek);
            btnCiftCenekli = FindViewById<Button>(Resource.Id.btnCiftCenek);
            btnKapal�TohumluGeri = FindViewById<Button>(Resource.Id.btnKapaliTohumluGeri);

            //button clickleri
            btnTekCenekli.Click += (sender, e) => { StartActivity(typeof(TekCenekliActivity)); Finish(); };
            btnCiftCenekli.Click += (sender, e) => { StartActivity(typeof(CiftCenekliActivity)); Finish(); };
            btnKapal�TohumluGeri.Click += (sender, e) => { StartActivity(typeof(CicekliActivity)); Finish(); };
                }
    }
}