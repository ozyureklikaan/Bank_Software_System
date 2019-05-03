using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYazilimOtomasyonu
{
    public interface IBankaIslemleri
    {
        void HesapAc(Hesap hesap);
        string HesapSil(int girilenHesapNo);
        string MusteriBul(long tc);
        string AdSoyadKontrol(long tc);
        string HesapBilgileriGoster(long tc);
    }
}
