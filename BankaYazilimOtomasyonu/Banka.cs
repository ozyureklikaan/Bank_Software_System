using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYazilimOtomasyonu
{
    public class Banka : IBankaIslemleri
    {
        protected static List<Hesap> Hesaplar = new List<Hesap>();
        public double Gelir { get; set; }
        public double Gider { get; set; }
        public double ToplamBakiye { get; set; }

        public void HesapAc(Hesap hesap)
        {
            Hesaplar.Add(hesap);
            Random rastgeleHesapNo = new Random();
            hesap.HesapNo = rastgeleHesapNo.Next(100000, 999999);
        }

        public string HesapSil(int girilenMusteriNo)
        {
            string mesaj = "";
            foreach (Hesap h in Hesaplar)
            {
                if (girilenMusteriNo == h.HesapNo)
                {
                    if (h.HesapBakiye == 0)
                    {
                        Hesaplar.Remove(h);
                        mesaj = "Hesap Silindi!";
                        break;
                    }
                    else
                    {
                        mesaj = "Hesap Bakiyesi 0 Değil!";
                        break;
                    }
                }
            }
            return mesaj;
        }

        public string HesapBilgileriGoster(long tc)
        {
            string strListele = "";
            foreach (Hesap h in Hesaplar)
            {
                if (tc == h.TC)
                {
                    strListele += "Hesap Numarası : " + h.HesapNo + "\nMüşteri Adı : " + h.Ad + "\nMüşteri Soyadı : " + h.Soyad + "\nMüşteri TC'si : " + h.TC + "\nHesap Türü :" + h.HesapTipi + "\nHesap Bakiyesi : " + h.HesapBakiye + "\n" + Environment.NewLine;
                }
            }
            return strListele;
        }

        public string MusteriBul(long tc)
        {
            string strMesaj = "Kayıt Bulunamadı.";
            foreach (Hesap h in Hesaplar)
            {
                if (tc == h.TC)
                {
                    strMesaj = "Giriş Başarılı.";
                    break;
                }
                else
                {
                    strMesaj = "Giriş Başarısız. Bilgilerinizi Kontrol Ediniz.";
                }
            }
            return strMesaj;
        }

        public string AdSoyadKontrol(long tc) // Kullanıcıların aynı TC numarasıyla farklı isimde hesap açmaları engellendi.
        {
            string mesaj = "";
            foreach (Hesap h in Hesaplar)
            {
                if (tc == h.TC)
                {
                    mesaj = h.Ad + h.Soyad;
                }
            }
            return mesaj;
        }
    }
}
