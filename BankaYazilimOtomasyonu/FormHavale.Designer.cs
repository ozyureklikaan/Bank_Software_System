namespace BankaYazilimOtomasyonu
{
    partial class FormHavale
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtYatirilacakHesap = new System.Windows.Forms.TextBox();
            this.txtCekilecekHesap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.MintCream;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnIptal.Location = new System.Drawing.Point(162, 202);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(121, 26);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnHavale
            // 
            this.btnHavale.BackColor = System.Drawing.Color.MintCream;
            this.btnHavale.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHavale.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHavale.Location = new System.Drawing.Point(16, 202);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(121, 26);
            this.btnHavale.TabIndex = 16;
            this.btnHavale.Text = "HAVALE YAP";
            this.btnHavale.UseVisualStyleBackColor = false;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtMiktar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMiktar.Location = new System.Drawing.Point(140, 158);
            this.txtMiktar.Multiline = true;
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(143, 22);
            this.txtMiktar.TabIndex = 15;
            // 
            // txtYatirilacakHesap
            // 
            this.txtYatirilacakHesap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtYatirilacakHesap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtYatirilacakHesap.Location = new System.Drawing.Point(140, 116);
            this.txtYatirilacakHesap.MaxLength = 6;
            this.txtYatirilacakHesap.Multiline = true;
            this.txtYatirilacakHesap.Name = "txtYatirilacakHesap";
            this.txtYatirilacakHesap.Size = new System.Drawing.Size(143, 22);
            this.txtYatirilacakHesap.TabIndex = 14;
            // 
            // txtCekilecekHesap
            // 
            this.txtCekilecekHesap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCekilecekHesap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCekilecekHesap.Location = new System.Drawing.Point(140, 43);
            this.txtCekilecekHesap.MaxLength = 6;
            this.txtCekilecekHesap.Multiline = true;
            this.txtCekilecekHesap.Name = "txtCekilecekHesap";
            this.txtCekilecekHesap.Size = new System.Drawing.Size(143, 22);
            this.txtCekilecekHesap.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 171);
            this.label1.TabIndex = 12;
            this.label1.Text = "Para Çekilecek Olan Hesabın\r\n\r\nHesap Numarası : \r\n\r\nPara Yatırılacak Olan Hesabın" +
    "\r\n\r\nHesap Numarası : \r\n\r\nYatırılacak Miktar :";
            // 
            // FormHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(301, 243);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtYatirilacakHesap);
            this.Controls.Add(this.txtCekilecekHesap);
            this.Controls.Add(this.label1);
            this.Name = "FormHavale";
            this.Text = "Havale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtYatirilacakHesap;
        private System.Windows.Forms.TextBox txtCekilecekHesap;
        private System.Windows.Forms.Label label1;
    }
}