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
    public partial class FormBanka : Form
    {
        public FormBanka()
        {
            InitializeComponent();
        }

        private void FormBanka_Load(object sender, EventArgs e)
        {
            Hesap h = new Hesap();
            string[] BankaBilgileri = h.BankaBilgiGoster();
            dataGelirGider.Rows.Add(); // dataGridView'e yeni satır ekler.
            dataGelirGider.Rows[0].Cells[0].Value = BankaBilgileri[0]; // Gelir sütununa bankaya toplam gelen parayı yazar.
            dataGelirGider.Rows[0].Cells[1].Value = BankaBilgileri[1]; // Gider sütununa bankadan toplam giden parayı yazar.
            dataGelirGider.Rows[0].Cells[2].Value = BankaBilgileri[2]; // Bankadaki net toplam miktarı yazar.
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
