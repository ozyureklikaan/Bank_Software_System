using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaYazilimOtomasyonu
{
    public partial class FormHesapOzeti : Form
    {
        public FormHesapOzeti()
        {
            InitializeComponent();
        }

        Hesap h = new Hesap();

        private void btnOzetGoster_Click(object sender, EventArgs e)
        {
            int hesapNo = Convert.ToInt32(txtHesapNo.Text);
            string[,] Ozet = h.HesapOzeti(hesapNo, dateBaslangic.Value.AddHours(00).AddMinutes(00).AddSeconds(01).ToUniversalTime(), dateBitis.Value.AddHours(23).AddMinutes(59).AddSeconds(59).ToUniversalTime());
            for (int k = 0; k < Islemler.islemSayisi; k++)
            {
                dataOzetGoster.Rows.Add(); // dataGridView'e yeni satır ekler.
                dataOzetGoster.Rows[k].Cells[0].Value = Ozet[k, 0];
                dataOzetGoster.Rows[k].Cells[1].Value = Ozet[k, 1];
                dataOzetGoster.Rows[k].Cells[2].Value = Ozet[k, 2];
                dataOzetGoster.Rows[k].Cells[3].Value = Ozet[k, 3];
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FormHesapOzeti_Load(object sender, EventArgs e)
        {

        }
    }
}
