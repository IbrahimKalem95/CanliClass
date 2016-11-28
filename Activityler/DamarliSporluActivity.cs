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
    [Activity(Label = "DamarlıSporluActivity")]
    public class DamarliSporluActivity : Activity
    {
        Button btnDamarliSporluGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DamarliSporlu);

            btnDamarliSporluGeri = FindViewById<Button>(Resource.Id.btnDamarliSporluGeris);

            btnDamarliSporluGeri.Click += (sender, e) => { StartActivity(typeof(CiceksizActivity)); Finish(); };
        }
    }
}