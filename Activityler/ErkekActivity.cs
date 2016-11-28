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
    [Activity(Label = "ErkekActivity")]
    public class ErkekActivity : Activity
    {
        Button btnGeriErkek;
        TextView txtErkekInfo;
        Erkek erkek = new Erkek();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Erkek);

            btnGeriErkek = FindViewById<Button>(Resource.Id.btnErkekGeri);
            txtErkekInfo = FindViewById<TextView>(Resource.Id.txtErkekInfo);

            btnGeriErkek.Click += (sender, e) => { StartActivity(typeof(InsanActivity)); Finish(); };
            DisplayErkekInfo();
        }
        public void DisplayErkekInfo()
        {


            erkek.m_ad = "Ýbrahim  \n";
            erkek.m_soyad = "Kalem\n";
            erkek.m_yas = 21;
            erkek.m_boy = 176;
            erkek.m_agýrlýk = 113;
            erkek.m_gözRengi = "Ela\n";
            erkek.m_sacYapýsý = "Kývýrcýk\n";
            erkek.m_bosaltimSekli = "Anüs\n";
            erkek.m_solunumSekli = "Akciðer solunumu\n";
            erkek.HücreTipi = "Hayvansal Hücre\n";
            erkek.BeslenmeSekli = "Hem etçil hem otçul\n";
            erkek.HareketSekli = "Aktif Hareket\n";
            erkek.UremeSekli = "Eseyli Üreme\n";
            erkek.Tcno = 27043659972;
            txtErkekInfo.Text = "Tc No  : " + erkek.Tcno + "\nAdý : " + erkek.m_ad + "Soyadý  : " + erkek.m_soyad + "Yas : " + erkek.m_yas + "\nBoy : " + erkek.m_boy + "\nAðýrlýk : " + erkek.m_agýrlýk +
               "\nGöz Rengi : " + erkek.m_gözRengi + "Saç Yapýsý : " + erkek.m_sacYapýsý + "Boþaltým Þekli : " + erkek.m_bosaltimSekli + "Solunum Þekli : " + erkek.m_solunumSekli +
               "Hücre Tipi : " + erkek.HücreTipi + "Beslenme Þekli : " + erkek.BeslenmeSekli + "Hareket Þekli : " + erkek.HareketSekli + "Üreme Þekli : " + erkek.UremeSekli;
        }
    }
}