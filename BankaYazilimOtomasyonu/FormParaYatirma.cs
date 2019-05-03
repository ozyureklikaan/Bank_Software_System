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
    public partial class FormParaYatirma : Form
    {
        public FormParaYatirma()
        {
            InitializeComponent();
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            Hesap h = new Hesap();
            string mesaj = h.ParaYatirma(Convert.ToDouble(txtYatirilacakMiktar.Text), Convert.ToInt32(txtYatirilacakHesap.Text));
            MessageBox.Show(mesaj);
            Dispose();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
