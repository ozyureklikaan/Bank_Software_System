namespace BankaYazilimOtomasyonu
{
    partial class FormParaYatirma
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
            this.btnYatir = new System.Windows.Forms.Button();
            this.txtYatirilacakMiktar = new System.Windows.Forms.TextBox();
            this.txtYatirilacakHesap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.Color.MintCream;
            this.btnIptal.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnIptal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnIptal.Location = new System.Drawing.Point(147, 176);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(121, 26);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İPTAL";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnYatir
            // 
            this.btnYatir.BackColor = System.Drawing.Color.MintCream;
            this.btnYatir.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnYatir.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnYatir.Location = new System.Drawing.Point(20, 176);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(121, 26);
            this.btnYatir.TabIndex = 13;
            this.btnYatir.Text = "PARAYI YATIR";
            this.btnYatir.UseVisualStyleBackColor = false;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // txtYatirilacakMiktar
            // 
            this.txtYatirilacakMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtYatirilacakMiktar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtYatirilacakMiktar.Location = new System.Drawing.Point(147, 133);
            this.txtYatirilacakMiktar.Multiline = true;
            this.txtYatirilacakMiktar.Name = "txtYatirilacakMiktar";
            this.txtYatirilacakMiktar.Size = new System.Drawing.Size(142, 22);
            this.txtYatirilacakMiktar.TabIndex = 12;
            // 
            // txtYatirilacakHesap
            // 
            this.txtYatirilacakHesap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtYatirilacakHesap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtYatirilacakHesap.Location = new System.Drawing.Point(147, 96);
            this.txtYatirilacakHesap.MaxLength = 6;
            this.txtYatirilacakHesap.Multiline = true;
            this.txtYatirilacakHesap.Name = "txtYatirilacakHesap";
            this.txtYatirilacakHesap.Size = new System.Drawing.Size(142, 22);
            this.txtYatirilacakHesap.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(17, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 114);
            this.label1.TabIndex = 10;
            this.label1.Text = "Parayı Yatırmak İstediğiniz Hesabınızın\r\n\r\nHesap Numarası : \r\n\r\nYatırılacak Mikta" +
    "r :\r\n\r\n";
            // 
            // FormParaYatirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(309, 262);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.txtYatirilacakMiktar);
            this.Controls.Add(this.txtYatirilacakHesap);
            this.Controls.Add(this.label1);
            this.Name = "FormParaYatirma";
            this.Text = "Para Yatırma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.TextBox txtYatirilacakMiktar;
        private System.Windows.Forms.TextBox txtYatirilacakHesap;
        private System.Windows.Forms.Label label1;
    }
}