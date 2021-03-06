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
    [Activity(Label = "DamarsizSporluActivity")]
    public class DamarsizSporluActivity : Activity
    {
        Button btnDamarsizSporluGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.DamarsizSporlu);

            btnDamarsizSporluGeri = FindViewById<Button>(Resource.Id.btnDamarsizSporluGeri);

            btnDamarsizSporluGeri.Click += (sender, e) => { StartActivity(typeof(CiceksizActivity)); Finish(); };
            }
    }
}