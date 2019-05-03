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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static int count = 0;
        public static string txtTc;
        Banka b = new Banka();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            txtTc = txtGirilenTc.Text;
            string mesaj = b.MusteriBul(Convert.ToInt64(txtGirilenTc.Text));
            MessageBox.Show(mesaj);
            if (mesaj == "Giriş Başarılı.")
            {
                for (int i = 1; i > 0; i++)
                {
                    FormHesap formHesap = new FormHesap();
                    this.Visible = false;
                    formHesap.ShowDialog();
                    if (FormHesap.cikis == "Çıkış Yapıldı")
                    {
                        this.Visible = true;
                        break;
                    }
                    if (FormHesapSil.mesaj == "Hesap Silindi!")
                    {
                        this.Visible = true;
                        break;
                    }
                }
            }
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            FormHesapAc formHesapAc = new FormHesapAc();
            this.Visible = false;
            formHesapAc.ShowDialog();
            this.Visible = true;
        }

        private void btnGelirGider_Click(object sender, EventArgs e)
        {
            FormBanka formBanka = new FormBanka();
            this.Visible = false;
            formBanka.ShowDialog();
            this.Visible = true;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
