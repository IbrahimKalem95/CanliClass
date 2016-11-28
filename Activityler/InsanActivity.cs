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
using CanliClass.Classlar;

namespace CanliClass.Activityler
{
    [Activity(Label = "InsanActivity")]
    public class InsanActivity : Activity
    {
        Button btnGeriInsan;
        Button btnErkek;
        Button btnKadin;
        TextView txtInsanInfo;
        Insanlar insan = new Insanlar();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Insan);

            //buttonlar�n cag�r�lmas�
            btnGeriInsan = FindViewById<Button>(Resource.Id.btnGeriInsan);
            btnErkek = FindViewById<Button>(Resource.Id.btnErkek);
            btnKadin = FindViewById<Button>(Resource.Id.btnKadin);
            txtInsanInfo = FindViewById<TextView>(Resource.Id.txtInsanInfo);

            //button clickleri
            //btnGeriInsan.Click += (sender, e) => { StartActivity(typeof(MainActivity));this.OnPanelClosed(); }; 

            btnGeriInsan.Click += (sender, e) => { Intent intent2 = new Intent(this, typeof(MainActivity)); StartActivity(intent2); Finish(); };
            btnKadin.Click += (sender, e) => { StartActivity(typeof(KadinActivity)); Finish(); };
            btnErkek.Click += (sender, e) => { StartActivity(typeof(ErkekActivity)); Finish(); };

            txtInsanInfo.Text = insan.m_�nfo = "�nsan, dik duru�a, g�rece geli�mi� bir beyine, soyut d���nme yetene�ine, konu�ma (dil kullanma) kabiliyetine, alet kullanma ve �retme becerisine sahip primat t�r�. Biominal ismi `Homo sapiens`tir. Homo sapiens Latince 'ak�ll� adam' veya 'bilen adam' anlam�na gelir. �nsan, hominoidea (insans�lar) �st ailesinin hominidae (b�y�k insans�lar) ailesine dahildir.";
            

        }
       


    }
}