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

namespace CanliClass.Classlar
{
    class Canlilar : Java.Lang.Object
    {
        public string m_ad = null;
        private string m_hücreTipi = null;
        private string m_beslenmeSekli = null;
        public string m_solunumSekli = null;
        public string m_bosaltimSekli = null;  
        private string m_hareketSekli = null;
        protected string m_uremeSekli = null;
        public string m_gözRengi = null;
        public int m_yas = 0;
        public int m_boy = 0;
        public int m_agırlık = 0;
        public string m_ınfo = null;

        public string HücreTipi { get { return m_hücreTipi; } set { m_hücreTipi = value; } }
        public string BeslenmeSekli { get { return m_beslenmeSekli; } set { m_beslenmeSekli = value; } }
        public string HareketSekli { get { return m_hareketSekli; } set { m_hareketSekli = value; } }
        public string UremeSekli { get { return m_uremeSekli; } set { m_uremeSekli = value; } }



    }
}