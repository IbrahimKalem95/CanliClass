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
    [Activity(Label = "KadinActivity")]
    public class KadinActivity : Activity
    {
        Button btnGeriKadin;
        TextView txtKadinInfo;
        Kadin kadin = new Kadin();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Kadin);

            btnGeriKadin = FindViewById<Button>(Resource.Id.btnKadinGeri);
            txtKadinInfo = FindViewById<TextView>(Resource.Id.txtKadinInfo);

            btnGeriKadin.Click += (sender, e) => { StartActivity(typeof(InsanActivity)); Finish(); };

            DisplayKadinInfo();
        }
        public void DisplayKadinInfo()
        {


            kadin.m_ad = "Ayse  \n";
            kadin.m_soyad = "Tutku\n";
            kadin.m_yas = 23;
            kadin.m_boy = 156;
            kadin.m_agýrlýk = 53;
            kadin.m_gözRengi = "Ela\n";
            kadin.m_sacYapýsý = "Dalgalý\n";
            kadin.m_bosaltimSekli = "Anüs\n";
            kadin.m_solunumSekli = "Akciðer solunumu\n";
            kadin.HücreTipi = "Hayvansal Hücre\n";
            kadin.BeslenmeSekli = "Otçul\n";
            kadin.HareketSekli = "Aktif Hareket\n";
            kadin.UremeSekli = "Eseyli Üreme\n";
            kadin.Tcno = 16533423422;
            txtKadinInfo.Text = "Tc No  : " + kadin.Tcno + "\nAdý : " + kadin.m_ad + "Soyadý  : " + kadin.m_soyad + "Yas : " + kadin.m_yas + "\nBoy : " + kadin.m_boy + "\nAðýrlýk : " + kadin.m_agýrlýk +
               "\nGöz Rengi : " + kadin.m_gözRengi + "Saç Yapýsý : " + kadin.m_sacYapýsý + "Boþaltým Þekli : " + kadin.m_bosaltimSekli + "Solunum Þekli : " + kadin.m_solunumSekli +
               "Hücre Tipi : " + kadin.HücreTipi + "Beslenme Þekli : " + kadin.BeslenmeSekli + "Hareket Þekli : " + kadin.HareketSekli + "Üreme Þekli : " + kadin.UremeSekli;
        }
    }
}