using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYazilimOtomasyonu
{
    public class Hesap : Musteri , IHesapIslemleri
    {
        protected static List<Islemler> Ozetler = new List<Islemler>();
        public int HesapNo { get; set; }
        public double HesapBakiye { get; set; }
        public string HesapTipi { get; set; }

        public Hesap()
        {
            HesapBakiye = 0;
        }

        public string ParaYatirma(double miktar, int hesapNo)
        {
            string mesaj = "Beklenmedik Hata Oluştu";
            foreach (Hesap h in Hesaplar)
            {
                if (hesapNo == h.HesapNo)
                {
                    h.HesapBakiye += miktar;
                    mesaj = "Para Yatırma İşleminiz Başarılı.";
                    Islemler i = new Islemler();
                    i.HesapNo = hesapNo;
                    i.IslemTuru = "Para Yatırma";
                    i.IslemDetayi = "Hesaba " + miktar + " TL Para Yatırıldı.";
                    i.IslemTarihi = DateTime.Now;
                    Ozetler.Add(i);
                    Islemler.islemSayisi++;
                    i.Miktar = miktar;
                    break;
                }
                else
                {
                    mesaj = "Hesap Numaranız Yanlış.";
                }
            }
            return mesaj;
        }

        public string ParaCekme(double miktar, int hesapNo)
        {
            string mesaj = "";
            string mesajLimit = "";
            foreach (Hesap h in Hesaplar)
            {
                if (hesapNo == h.HesapNo)
                {
                    if (h.HesapBakiye >= miktar)
                    {
                        mesajLimit = GunlukLimitHesapla(hesapNo, miktar);
                        if (mesajLimit == "")
                        {
                            h.HesapBakiye -= miktar;
                            mesaj = "" + h.HesapNo + " Numaralı Hesabınızdan Para Çekme İşleminiz Başarılı.";
                            Islemler i = new Islemler();
                            i.HesapNo = hesapNo;
                            i.IslemTuru = "Para Çekme";
                            i.IslemDetayi = "Hesaptan " + miktar + " TL Para Çekildi.";
                            i.IslemTarihi = DateTime.Now;
                            Ozetler.Add(i);
                            Islemler.islemSayisi++;
                            i.Miktar = miktar;
                            break;
                        }
                        else
                        {
                            mesaj = "Günlük Limiti Aştınız.";
                        }
                    }
                    else
                    {
                        mesaj = "Bakiye Yetersiz.Lütfen Başka Hesabınız Varsa Tekrar Deneyin.";
                    }
                }
                else
                {
                    mesaj = "Hesap Numaranız Yanlış.";
                }
            }
            return mesaj;
        }

        public string HesabaHavale(double miktar, int hesapNo1, int hesapNo2)
        {
            string mesaj = "";
            foreach (Hesap h1 in Hesaplar)
            {
                if (hesapNo1 == h1.HesapNo)
                {
                    foreach (Hesap h2 in Hesaplar)
                    {
                        if (hesapNo2 == h2.HesapNo)
                        {
                            if (h1.HesapBakiye >= miktar)
                            {
                                if (h1.HesapTipi == "Ticari")
                                {
                                    h1.HesapBakiye -= miktar;
                                }
                                else if (h1.HesapBakiye >= miktar * 102 / 100)
                                {
                                    h1.HesapBakiye -= miktar * 102 / 100;
                                }
                                else
                                {
                                    mesaj = "Hesaptan Yeterli Havale Ücreti Kesilemedi.";
                                    break;
                                }
                                h2.HesapBakiye += miktar;
                                mesaj = "Havale İşleminiz Başarılı.";
                                Islemler i = new Islemler();
                                i.HesapNo = hesapNo1;
                                i.IslemTuru = "Para Havale";
                                i.IslemDetayi = "Hesaptan" + miktar + " TL" + hesapNo2 + " nolu Hesaba Havale Yapıldı.";
                                i.IslemTarihi = DateTime.Now;
                                Ozetler.Add(i);
                                Islemler.islemSayisi++;
                                i.Miktar = miktar;
                                break;
                            }
                            else
                            {
                                mesaj = "Bakiyeniz Yetersiz. ";
                            }
                        }
                        else
                        {
                            mesaj = "Havale Yapılacak Hesabın Hesap Numarası Yanlış.";
                        }
                    }
                    break;
                }
                else if (mesaj != "Havale İşleminiz Başarılı." || mesaj != "Hesaptan Yeterli Havale Ücreti Kesilemedi.")
                {
                    mesaj = "Paranın Çekileceği Hesabın Hesap Numarası Yanlış.";
                }

            }
            return mesaj;
        }

        public string[,] HesapOzeti(int musteriNo, DateTime tarih1, DateTime tarih2)
        {
            int b = 0;
            string[,] Ozet = new string[Islemler.islemSayisi, 4];
            int a = Islemler.islemSayisi;
            foreach (Islemler i in Ozetler)
            {
                if (musteriNo == i.HesapNo)
                {
                    if (tarih1 < i.IslemTarihi && tarih2 > i.IslemTarihi)
                    {
                        if (b < Islemler.islemSayisi)
                        {
                            Ozet[b, 0] = Convert.ToString(i.HesapNo);
                            Ozet[b, 1] = i.IslemTuru;
                            Ozet[b, 2] = i.IslemDetayi;
                            Ozet[b, 3] = Convert.ToString(i.IslemTarihi);
                            b++;
                        }
                    }
                }
            }
            return Ozet;
        }

        public string GunlukLimitHesapla(int hesapNo, double miktar)
        {
            string mesaj = "";
            DateTime gunBaslangici = DateTime.Now.Date;
            DateTime gunBitisi = DateTime.Now.Date.AddHours(26).AddMinutes(59).AddSeconds(59).ToUniversalTime();
            foreach (Islemler i in Ozetler)
            {
                if (hesapNo == i.HesapNo)
                {
                    if (gunBaslangici <= i.IslemTarihi && gunBitisi >= i.IslemTarihi)
                    {
                        if ((Islemler.gunlukLimit + miktar) <= 750)
                        {
                            Islemler.gunlukLimit += miktar;
                        }
                        else
                        {
                            mesaj = "Para Çekme İşleminiz Başarısız.Limitiniz 750 TL'yi Aştı.";
                        }
                    }
                    else
                    {
                        Islemler.gunlukLimit = 0;
                    }
                }
            }
            return mesaj;
        }

        public string[] BankaBilgiGoster()
        {
            Hesap h = new Hesap();
            Banka b = new Banka();
            b.Gelir = 0;
            b.Gider = 0;
            b.ToplamBakiye = 0;
            string[] bankaBilgileri = new string[3];

            foreach (Islemler i in Ozetler)
            {
                if (i.IslemTuru == "Para Yatırma")
                {
                    b.Gelir += i.Miktar;
                }
                else if (i.IslemTuru == "Para Çekme")
                {
                    b.Gider -= i.Miktar;
                }
                else if (i.IslemTuru == "Para Havale")
                {
                    if (h.HesapTipi == "Bireysel")
                    {
                        b.Gelir += (i.Miktar * 2) / 100;
                    }
                }
            }
            b.ToplamBakiye = b.Gelir + b.Gider;
            bankaBilgileri[0] = Convert.ToString(b.Gelir);
            bankaBilgileri[1] = Convert.ToString(b.Gider);
            bankaBilgileri[2] = Convert.ToString(b.ToplamBakiye);
            return bankaBilgileri;
        }
    }
}
