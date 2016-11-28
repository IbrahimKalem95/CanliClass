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
    
    [Activity(Label = "CicekliActivity")]
    public class CicekliActivity : Activity
    {
        Button btnAcikTohumlu;
        Button btnKapaliTohumlu;
        Button btnCicekliGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Cicekli);


            //buttonlarýn cagýrýlmasý
            btnAcikTohumlu = FindViewById<Button>(Resource.Id.btnAcikTohumlu);
            btnKapaliTohumlu = FindViewById<Button>(Resource.Id.btnKapaliTohumlu);
            btnCicekliGeri = FindViewById<Button>(Resource.Id.btnCicekliGeri);

            //button clickleri
            btnAcikTohumlu.Click += (sender, e) => { StartActivity(typeof(AcikTohumluActivity)); Finish(); };
            btnKapaliTohumlu.Click += (sender, e) => { StartActivity(typeof(KapaliTohumluActivity)); Finish(); };
            btnCicekliGeri.Click += (sender, e) => { StartActivity(typeof(BitkiActivity)); Finish(); };
        }
    }
}