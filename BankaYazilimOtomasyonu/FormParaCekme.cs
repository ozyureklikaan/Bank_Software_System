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
    public partial class FormParaCekme : Form
    {
        public FormParaCekme()
        {
            InitializeComponent();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            Hesap h = new Hesap();
            string mesaj = h.ParaCekme(Convert.ToDouble(txtCekilecekMiktar.Text), Convert.ToInt32(txtCekilecekHesap.Text));
            MessageBox.Show(mesaj);
            if (mesaj == "Bakiye Yetersiz.Lütfen Başka Hesabınız Varsa Tekrar Deneyin.")
            {

            }
            else
            {
                Dispose();
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
