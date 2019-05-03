namespace BankaYazilimOtomasyonu
{
    partial class FormHesapAc
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
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkTicari = new System.Windows.Forms.CheckBox();
            this.checkBireysel = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.Color.MintCream;
            this.btnHesapAc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHesapAc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHesapAc.Location = new System.Drawing.Point(94, 207);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(142, 26);
            this.btnHesapAc.TabIndex = 29;
            this.btnHesapAc.Text = "HESAP AÇ";
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(8, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hesap Türü :";
            // 
            // checkTicari
            // 
            this.checkTicari.AutoSize = true;
            this.checkTicari.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkTicari.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.checkTicari.Location = new System.Drawing.Point(224, 157);
            this.checkTicari.Name = "checkTicari";
            this.checkTicari.Size = new System.Drawing.Size(105, 23);
            this.checkTicari.TabIndex = 27;
            this.checkTicari.Text = "Ticari Hesap";
            this.checkTicari.UseVisualStyleBackColor = true;
            this.checkTicari.CheckedChanged += new System.EventHandler(this.checkTicari_CheckedChanged);
            // 
            // checkBireysel
            // 
            this.checkBireysel.AutoSize = true;
            this.checkBireysel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.checkBireysel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.checkBireysel.Location = new System.Drawing.Point(100, 157);
            this.checkBireysel.Name = "checkBireysel";
            this.checkBireysel.Size = new System.Drawing.Size(118, 23);
            this.checkBireysel.TabIndex = 26;
            this.checkBireysel.Text = "Bireysel Hesap";
            this.checkBireysel.UseVisualStyleBackColor = true;
            this.checkBireysel.CheckedChanged += new System.EventHandler(this.checkBireysel_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(22, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "TC No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(22, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ad :";
            // 
            // txtTc
            // 
            this.txtTc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtTc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtTc.Location = new System.Drawing.Point(97, 113);
            this.txtTc.MaxLength = 11;
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(142, 22);
            this.txtTc.TabIndex = 22;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtSoyad.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSoyad.Location = new System.Drawing.Point(97, 73);
            this.txtSoyad.Multiline = true;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(142, 22);
            this.txtSoyad.TabIndex = 21;
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtAd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtAd.Location = new System.Drawing.Point(97, 35);
            this.txtAd.Multiline = true;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(142, 22);
            this.txtAd.TabIndex = 20;
            // 
            // FormHesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkTicari);
            this.Controls.Add(this.checkBireysel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "FormHesapAc";
            this.Text = "Hesap Aç";
            this.Load += new System.EventHandler(this.FormHesapAc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkTicari;
        private System.Windows.Forms.CheckBox checkBireysel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
    }
}