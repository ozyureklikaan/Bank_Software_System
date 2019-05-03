namespace BankaYazilimOtomasyonu
{
    partial class FormMain
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
            this.btnGelirGider = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtGirilenTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.BackColor = System.Drawing.Color.MintCream;
            this.btnHesapAc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnHesapAc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnHesapAc.Location = new System.Drawing.Point(11, 137);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(129, 26);
            this.btnHesapAc.TabIndex = 17;
            this.btnHesapAc.Text = "HESAP AÇ";
            this.btnHesapAc.UseVisualStyleBackColor = false;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // btnGelirGider
            // 
            this.btnGelirGider.BackColor = System.Drawing.Color.MintCream;
            this.btnGelirGider.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGelirGider.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGelirGider.Location = new System.Drawing.Point(148, 137);
            this.btnGelirGider.Name = "btnGelirGider";
            this.btnGelirGider.Size = new System.Drawing.Size(129, 26);
            this.btnGelirGider.TabIndex = 16;
            this.btnGelirGider.Text = "BANKA GELİR-GİDER";
            this.btnGelirGider.UseVisualStyleBackColor = false;
            this.btnGelirGider.Click += new System.EventHandler(this.btnGelirGider_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.MintCream;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.Location = new System.Drawing.Point(74, 180);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(140, 26);
            this.btnCikis.TabIndex = 15;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.MintCream;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnGiris.Location = new System.Drawing.Point(131, 91);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(146, 26);
            this.btnGiris.TabIndex = 14;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtGirilenTc
            // 
            this.txtGirilenTc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtGirilenTc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtGirilenTc.Location = new System.Drawing.Point(148, 55);
            this.txtGirilenTc.MaxLength = 11;
            this.txtGirilenTc.Multiline = true;
            this.txtGirilenTc.Name = "txtGirilenTc";
            this.txtGirilenTc.Size = new System.Drawing.Size(146, 22);
            this.txtGirilenTc.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(8, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "TC Kimlik Numarası :";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(301, 261);
            this.Controls.Add(this.btnHesapAc);
            this.Controls.Add(this.btnGelirGider);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtGirilenTc);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.Text = "Banka Yazılım Otomasyonu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Button btnGelirGider;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtGirilenTc;
        private System.Windows.Forms.Label label1;
    }
}