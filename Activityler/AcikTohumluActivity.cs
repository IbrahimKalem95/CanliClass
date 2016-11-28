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
    [Activity(Label = "AcıkiTohumluActivity")]
    public class AcikTohumluActivity : Activity
    {
        Button btnAcikTohumluGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AcikTohumlu);

             btnAcikTohumluGeri = FindViewById<Button>(Resource.Id.btnAcikTohumlularGeri);

            btnAcikTohumluGeri.Click += (sender, e) => { StartActivity(typeof(CicekliActivity)); Finish();
        };
    }
    }
}