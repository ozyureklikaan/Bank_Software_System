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
    public partial class FormHesap : Form
    {
        public FormHesap()
        {
            InitializeComponent();
        }

        public static string cikis;
        Banka b = new Banka();

        private void FormHesap_Load(object sender, EventArgs e)
        {
            lblHesapBilgileri.Text = b.HesapBilgileriGoster(Convert.ToInt64(FormMain.txtTc));
            cikis = "";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            cikis = "Çıkış Yapıldı";
            Dispose();
        }

        private void hesapÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHesapOzeti formHesapOzeti = new FormHesapOzeti();
            formHesapOzeti.ShowDialog();
            Dispose();
        }

        private void hesapSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHesapSil formHesapSil = new FormHesapSil();
            formHesapSil.ShowDialog();
            Dispose();
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParaCekme formParaCekme = new FormParaCekme();
            formParaCekme.ShowDialog();
            Dispose();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParaYatirma formParaYatirma = new FormParaYatirma();
            formParaYatirma.ShowDialog();
            Dispose();
        }

        private void paraHavaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHavale formHavale = new FormHavale();
            formHavale.ShowDialog();
            Dispose();
        }
    }
}
