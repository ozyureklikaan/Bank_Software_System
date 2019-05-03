namespace BankaYazilimOtomasyonu
{
    partial class FormParaCekme
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
            this.btnCek = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.txtCekilecekMiktar = new System.Windows.Forms.TextBox();
            this.txtCekilecekHesap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCek
            // 
            this.btnCek.BackColor = System.Drawing.Color.MintCream;
            this.btnCek.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCek.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCek.Location = new System.Drawing.Point(20, 169);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(115, 26);
            this.btnCek.TabIndex = 14;
            this.btnCek.Text = "PARAYI ÇEK";
            this.btnCek.UseVisualStyleBackColor = false;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.MintCream;
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGeri.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGeri.Location = new System.Drawing.Point(152, 169);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(115, 26);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "GERİ";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // txtCekilecekMiktar
            // 
            this.txtCekilecekMiktar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCekilecekMiktar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCekilecekMiktar.Location = new System.Drawing.Point(137, 141);
            this.txtCekilecekMiktar.Multiline = true;
            this.txtCekilecekMiktar.Name = "txtCekilecekMiktar";
            this.txtCekilecekMiktar.Size = new System.Drawing.Size(135, 22);
            this.txtCekilecekMiktar.TabIndex = 12;
            // 
            // txtCekilecekHesap
            // 
            this.txtCekilecekHesap.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCekilecekHesap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtCekilecekHesap.Location = new System.Drawing.Point(137, 102);
            this.txtCekilecekHesap.MaxLength = 6;
            this.txtCekilecekHesap.Multiline = true;
            this.txtCekilecekHesap.Name = "txtCekilecekHesap";
            this.txtCekilecekHesap.Size = new System.Drawing.Size(135, 22);
            this.txtCekilecekHesap.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 95);
            this.label1.TabIndex = 11;
            this.label1.Text = "Para Çekmek İstediğiniz Hesabınızın \r\n\r\nHesap Numarası : \r\n\r\nMiktar : ";
            // 
            // FormParaCekme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.txtCekilecekMiktar);
            this.Controls.Add(this.txtCekilecekHesap);
            this.Controls.Add(this.label1);
            this.Name = "FormParaCekme";
            this.Text = "Para Çekme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtCekilecekMiktar;
        private System.Windows.Forms.TextBox txtCekilecekHesap;
        private System.Windows.Forms.Label label1;
    }
}