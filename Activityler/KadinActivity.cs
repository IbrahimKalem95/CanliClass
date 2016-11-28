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
            kadin.m_ag�rl�k = 53;
            kadin.m_g�zRengi = "Ela\n";
            kadin.m_sacYap�s� = "Dalgal�\n";
            kadin.m_bosaltimSekli = "An�s\n";
            kadin.m_solunumSekli = "Akci�er solunumu\n";
            kadin.H�creTipi = "Hayvansal H�cre\n";
            kadin.BeslenmeSekli = "Ot�ul\n";
            kadin.HareketSekli = "Aktif Hareket\n";
            kadin.UremeSekli = "Eseyli �reme\n";
            kadin.Tcno = 16533423422;
            txtKadinInfo.Text = "Tc No  : " + kadin.Tcno + "\nAd� : " + kadin.m_ad + "Soyad�  : " + kadin.m_soyad + "Yas : " + kadin.m_yas + "\nBoy : " + kadin.m_boy + "\nA��rl�k : " + kadin.m_ag�rl�k +
               "\nG�z Rengi : " + kadin.m_g�zRengi + "Sa� Yap�s� : " + kadin.m_sacYap�s� + "Bo�alt�m �ekli : " + kadin.m_bosaltimSekli + "Solunum �ekli : " + kadin.m_solunumSekli +
               "H�cre Tipi : " + kadin.H�creTipi + "Beslenme �ekli : " + kadin.BeslenmeSekli + "Hareket �ekli : " + kadin.HareketSekli + "�reme �ekli : " + kadin.UremeSekli;
        }
    }
}