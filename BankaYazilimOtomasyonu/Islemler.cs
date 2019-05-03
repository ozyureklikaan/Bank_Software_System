using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYazilimOtomasyonu
{
    public class Islemler : Hesap
    {
        public static double gunlukLimit = 0;
        public static int islemSayisi = 0;
        public string IslemTuru { get; set; }
        public string IslemDetayi { get; set; }
        public DateTime IslemTarihi { get; set; }
        public double Miktar { get; set; }
    }
}
