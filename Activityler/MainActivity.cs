
using Android.App;
using Android.Widget;
using Android.OS;
using CanliClass.Activityler;
using Android.Content;
using Android.Graphics;
using CanliClass.Classlar;

namespace CanliClass.Activityler
{
    [Activity(Label = "CanliClass", MainLauncher = true, Icon = "@drawable/icon")]
   
    public class MainActivity : Activity
    {
        Button btnInsan;
        Button btnHayvan;
        Button btnBitki;
        Button btnCıkıs;
        TextView txtCanliInfo;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            //tanımlamalar ve cast işlemleri
            btnInsan = FindViewById<Button>(Resource.Id.btnInsan);
            btnHayvan = FindViewById<Button>(Resource.Id.btnHayvan);
            btnBitki = FindViewById<Button>(Resource.Id.btnBitkiler);
            btnCıkıs = FindViewById<Button>(Resource.Id.btnCikis);
            txtCanliInfo = FindViewById<TextView>(Resource.Id.txtCanliInfo);
           

            //Classlardan nesne uretme işlemleri
            Canlilar canliInfo = new Canlilar();

            //Button clickleri
            btnInsan.Click += (sender, e) => { StartActivity(typeof(InsanActivity)); Finish(); };
            btnBitki.Click += (sender, e) => { StartActivity(typeof(BitkiActivity)); Finish(); };
            btnHayvan.Click += (sender, e) => { StartActivity(typeof(HayvanActivity)); Finish(); };
            btnCıkıs.Click += (sender, e) => this.Finish();

            // nesnelerı kulanarak classlara ulasılan bılgıler
            txtCanliInfo.Text = canliInfo.m_ınfo = "Canlılar alemi insanlar, hayvanlar ve bitkiler olmak üzere  3'e ayrılmaktadır. Bilgi almak istediğiniz buttona tıklayınız. ";
            
           
           
        }

        
    }
}

