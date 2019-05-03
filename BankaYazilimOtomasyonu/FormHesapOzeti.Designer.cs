namespace BankaYazilimOtomasyonu
{
    partial class FormHesapOzeti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataOzetGoster = new System.Windows.Forms.DataGridView();
            this.hesapNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemDetayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnOzetGoster = new System.Windows.Forms.Button();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.dateBitis = new System.Windows.Forms.DateTimePicker();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataOzetGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // dataOzetGoster
            // 
            this.dataOzetGoster.AllowUserToAddRows = false;
            this.dataOzetGoster.AllowUserToDeleteRows = false;
            this.dataOzetGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOzetGoster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hesapNo,
            this.islemTuru,
            this.islemDetayi,
            this.islemTarihi});
            this.dataOzetGoster.Location = new System.Drawing.Point(7, 182);
            this.dataOzetGoster.Name = "dataOzetGoster";
            this.dataOzetGoster.ReadOnly = true;
            this.dataOzetGoster.Size = new System.Drawing.Size(444, 126);
            this.dataOzetGoster.TabIndex = 20;
            // 
            // hesapNo
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MintCream;
            this.hesapNo.DefaultCellStyle = dataGridViewCellStyle1;
            this.hesapNo.HeaderText = "Hesap Numarası";
            this.hesapNo.Name = "hesapNo";
            this.hesapNo.ReadOnly = true;
            // 
            // islemTuru
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MintCream;
            this.islemTuru.DefaultCellStyle = dataGridViewCellStyle2;
            this.islemTuru.HeaderText = "İşlem Türü";
            this.islemTuru.Name = "islemTuru";
            this.islemTuru.ReadOnly = true;
            // 
            // islemDetayi
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MintCream;
            this.islemDetayi.DefaultCellStyle = dataGridViewCellStyle3;
            this.islemDetayi.HeaderText = "İşlem Detayı";
            this.islemDetayi.Name = "islemDetayi";
            this.islemDetayi.ReadOnly = true;
            // 
            // islemTarihi
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.MintCream;
            this.islemTarihi.DefaultCellStyle = dataGridViewCellStyle4;
            this.islemTarihi.HeaderText = "İşlem Tarihi";
            this.islemTarihi.Name = "islemTarihi";
            this.islemTarihi.ReadOnly = true;
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.MintCream;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGeri.Location = new System.Drawing.Point(183, 150);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(106, 26);
            this.btnGeri.TabIndex = 19;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnOzetGoster
            // 
            this.btnOzetGoster.BackColor = System.Drawing.Color.MintCream;
            this.btnOzetGoster.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnOzetGoster.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOzetGoster.Location = new System.Drawing.Point(16, 150);
            this.btnOzetGoster.Name = "btnOzetGoster";
            this.btnOzetGoster.Size = new System.Drawing.Size(145, 26);
            this.btnOzetGoster.TabIndex = 18;
            this.btnOzetGoster.Text = "HESAP ÖZETİ GÖSTER";
            this.btnOzetGoster.UseVisualStyleBackColor = false;
            this.btnOzetGoster.Click += new System.EventHandler(this.btnOzetGoster_Click);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtHesapNo.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtHesapNo.Location = new System.Drawing.Point(137, 37);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(152, 26);
            this.txtHesapNo.TabIndex = 17;
            // 
            // dateBitis
            // 
            this.dateBitis.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateBitis.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBitis.Location = new System.Drawing.Point(137, 114);
            this.dateBitis.Name = "dateBitis";
            this.dateBitis.Size = new System.Drawing.Size(152, 26);
            this.dateBitis.TabIndex = 15;
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateBaslangic.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateBaslangic.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateBaslangic.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dateBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBaslangic.Location = new System.Drawing.Point(137, 75);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(152, 26);
            this.dateBaslangic.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 133);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hesap Özetini Görmek İçin : \r\n\r\nHesap Numarası : \r\n\r\nBaşlangıç Tarihi :\r\n\r\nBitiş " +
    "Tarihi :\r\n";
            // 
            // FormHesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(470, 326);
            this.Controls.Add(this.dataOzetGoster);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnOzetGoster);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.dateBitis);
            this.Controls.Add(this.dateBaslangic);
            this.Controls.Add(this.label1);
            this.Name = "FormHesapOzeti";
            this.Text = "Hesap Özeti";
            this.Load += new System.EventHandler(this.FormHesapOzeti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataOzetGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataOzetGoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemDetayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTarihi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnOzetGoster;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.DateTimePicker dateBitis;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private System.Windows.Forms.Label label1;
    }
}