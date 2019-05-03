using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaYazilimOtomasyonu
{
    public abstract class Musteri : Banka
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TC { get; set; }
    }
}
