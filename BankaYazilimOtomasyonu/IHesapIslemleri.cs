using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYazilimOtomasyonu
{
    public interface IHesapIslemleri
    {
        string ParaYatirma(double miktar, int hesapNo);
        string ParaCekme(double miktar, int hesapNo);
        string HesabaHavale(double miktar, int hesapNo1, int hesapNo2);
        string[,] HesapOzeti(int hesapNo, DateTime tarih1, DateTime tarih2);
        string GunlukLimitHesapla(int hesapNo, double miktar);
        string[] BankaBilgiGoster();
    }
}
