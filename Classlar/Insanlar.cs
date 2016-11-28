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

namespace CanliClass.Classlar
{
    class Insanlar : Canlilar
    {
        private long m_tcNo = 0;
        public string m_soyad = null;
        public string m_sacYapýsý = null;


        public long Tcno { get { return m_tcNo; } set { m_tcNo = value; } }

    }
}