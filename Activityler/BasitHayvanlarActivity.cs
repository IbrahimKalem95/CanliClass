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
    [Activity(Label = "BasitHayvanlarActivity")]
    public class BasitHayvanlarActivity : Activity
    {
        Button btnBasitHayvanGeri;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.BasitHayvanlar);

            btnBasitHayvanGeri = FindViewById<Button>(Resource.Id.btnBasitHayvanGeri);

            btnBasitHayvanGeri.Click += (sender, e) =>
            {
                StartActivity(typeof(HayvanActivity)); Finish();
            };
        }
    }
}