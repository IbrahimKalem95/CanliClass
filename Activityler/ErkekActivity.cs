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


            erkek.m_ad = "�brahim  \n";
            erkek.m_soyad = "Kalem\n";
            erkek.m_yas = 21;
            erkek.m_boy = 176;
            erkek.m_ag�rl�k = 113;
            erkek.m_g�zRengi = "Ela\n";
            erkek.m_sacYap�s� = "K�v�rc�k\n";
            erkek.m_bosaltimSekli = "An�s\n";
            erkek.m_solunumSekli = "Akci�er solunumu\n";
            erkek.H�creTipi = "Hayvansal H�cre\n";
            erkek.BeslenmeSekli = "Hem et�il hem ot�ul\n";
            erkek.HareketSekli = "Aktif Hareket\n";
            erkek.UremeSekli = "Eseyli �reme\n";
            erkek.Tcno = 27043659972;
            txtErkekInfo.Text = "Tc No  : " + erkek.Tcno + "\nAd� : " + erkek.m_ad + "Soyad�  : " + erkek.m_soyad + "Yas : " + erkek.m_yas + "\nBoy : " + erkek.m_boy + "\nA��rl�k : " + erkek.m_ag�rl�k +
               "\nG�z Rengi : " + erkek.m_g�zRengi + "Sa� Yap�s� : " + erkek.m_sacYap�s� + "Bo�alt�m �ekli : " + erkek.m_bosaltimSekli + "Solunum �ekli : " + erkek.m_solunumSekli +
               "H�cre Tipi : " + erkek.H�creTipi + "Beslenme �ekli : " + erkek.BeslenmeSekli + "Hareket �ekli : " + erkek.HareketSekli + "�reme �ekli : " + erkek.UremeSekli;
        }
    }
}