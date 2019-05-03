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
    public partial class FormHesapSil : Form
    {
        public FormHesapSil()
        {
            InitializeComponent();
        }

        public static string mesaj;

        private void btnSil_Click(object sender, EventArgs e)
        {
            Hesap h = new Hesap();
            mesaj = h.HesapSil(Convert.ToInt32(txtSilinecekHesapNo.Text));
            MessageBox.Show(mesaj);
            Dispose();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
