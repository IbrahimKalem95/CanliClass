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
    [Activity(Label = "CiceksizActivity")]
    public class CiceksizActivity : Activity
    {
        Button btnDamarliSporlu;
        Button btnDamarsizSporlu;
        Button btnCiceksizGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Ciceksiz);

            //buttonlar�n cag�r�lmas�
            btnDamarliSporlu = FindViewById<Button>(Resource.Id.btnDamarl�Sporlu);
            btnDamarsizSporlu = FindViewById<Button>(Resource.Id.btnDamars�zSporlu);
            btnCiceksizGeri = FindViewById<Button>(Resource.Id.btnCiceksizGeri);

            //button clickleri
            btnDamarliSporlu.Click += (sender, e) => { StartActivity(typeof(DamarliSporluActivity)); Finish(); };
            btnDamarsizSporlu.Click += (sender, e) => { StartActivity(typeof(DamarsizSporluActivity)); Finish(); };
            btnCiceksizGeri.Click += (sender, e) => { StartActivity(typeof(BitkiActivity)); Finish(); };
                }
    }
}