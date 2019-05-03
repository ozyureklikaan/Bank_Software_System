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
    public partial class FormHesapAc : Form
    {
        public FormHesapAc()
        {
            InitializeComponent();
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            Hesap h = new Hesap();
            if (txtAd.Text == "")
            {
                MessageBox.Show("Bilgilerinizi Eksiksiz Giriniz.");
            }
            else if (txtSoyad.Text == "")
            {
                MessageBox.Show("Bilgilerinizi Eksiksiz Giriniz.");
            }
            else if (txtTc.Text == "")
            {
                MessageBox.Show("Bilgilerinizi Eksiksiz Giriniz.");
            }
            else
            {
                if (txtTc.Text.Length == 11)
                {
                    if (FormMain.count == 0)
                    {
                        h.TC = Convert.ToInt64(txtTc.Text);
                        h.Ad = txtAd.Text;
                        h.Soyad = txtSoyad.Text;
                        if (checkBireysel.Checked == true)
                        {
                            h.HesapTipi = "Bireysel";
                            h.HesapAc(h);
                            MessageBox.Show("Bireysel Hesabınız Başarıyla Açıldı.");
                            Dispose();
                        }
                        else if (checkTicari.Checked == true)
                        {
                            h.HesapTipi = "Ticari";
                            h.HesapAc(h);
                            MessageBox.Show("Ticari Hesabınız Başarıyla Açıldı.");
                            Dispose();
                        }
                        FormMain.count++;
                    }
                    else
                    {
                        h.TC = Convert.ToInt64(txtTc.Text);
                        string AdSoyad = txtAd.Text + txtSoyad.Text;
                        string adSoyad = h.AdSoyadKontrol(Convert.ToInt64(txtTc.Text));
                        if (adSoyad == AdSoyad)
                        {
                            h.Ad = txtAd.Text;
                            h.Soyad = txtSoyad.Text;
                            if (checkBireysel.Checked == true)
                            {
                                h.HesapTipi = "Bireysel";
                                h.HesapAc(h);
                                MessageBox.Show("Bireysel Hesabınız Başarıyla Açıldı.");
                                Dispose();
                            }
                            else if (checkTicari.Checked == true)
                            {
                                h.HesapTipi = "Ticari";
                                h.HesapAc(h);
                                MessageBox.Show("Ticari Hesabınız Başarıyla Açıldı.");
                                Dispose();
                            }
                        }
                        else if (adSoyad == "")
                        {
                            h.Ad = txtAd.Text;
                            h.Soyad = txtSoyad.Text;
                            if (checkBireysel.Checked == true)
                            {
                                h.HesapTipi = "Bireysel";
                                h.HesapAc(h);
                                MessageBox.Show("Bireysel Hesabınız Başarıyla Açıldı.");
                                Dispose();
                            }
                            else if (checkTicari.Checked == true)
                            {
                                h.HesapTipi = "Ticari";
                                h.HesapAc(h);
                                MessageBox.Show("Ticari Hesabınız Başarıyla Açıldı.");
                                Dispose();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Girdiğiniz TC Kimlik Numarası Başka Hesaba Aittir.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Girdiğiniz TC Kimlik Numarası Yanlış. Lütfen 11 Haneli TC KimliK Numaranızı Giriniz.");
                }
            }
        }

        private void checkBireysel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBireysel.Checked == true)
            {
                checkTicari.Enabled = false;
            }
            else
            {
                checkTicari.Enabled = true;
            }
        }

        private void checkTicari_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTicari.Checked == true)
            {
                checkBireysel.Enabled = false;
            }
            else
            {
                checkBireysel.Enabled = true;
            }
        }

        private void FormHesapAc_Load(object sender, EventArgs e)
        {

        }
    }
}
