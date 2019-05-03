namespace BankaYazilimOtomasyonu
{
    partial class FormHesap
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iŞLEMMENÜSÜToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapÖzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraHavaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblHesapBilgileri = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.MintCream;
            this.btnCikis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCikis.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCikis.Location = new System.Drawing.Point(0, 235);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(284, 26);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "HESAPTAN ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label.Location = new System.Drawing.Point(12, 99);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 19);
            this.label.TabIndex = 8;
            this.label.Text = "HESAP BİLGİLERİ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iŞLEMMENÜSÜToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(131, 27);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iŞLEMMENÜSÜToolStripMenuItem
            // 
            this.iŞLEMMENÜSÜToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapToolStripMenuItem,
            this.paraİşlemleriToolStripMenuItem});
            this.iŞLEMMENÜSÜToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.iŞLEMMENÜSÜToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.iŞLEMMENÜSÜToolStripMenuItem.Name = "iŞLEMMENÜSÜToolStripMenuItem";
            this.iŞLEMMENÜSÜToolStripMenuItem.Size = new System.Drawing.Size(123, 23);
            this.iŞLEMMENÜSÜToolStripMenuItem.Text = "İŞLEM MENÜSÜ";
            // 
            // hesapToolStripMenuItem
            // 
            this.hesapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapÖzetiToolStripMenuItem,
            this.hesapSilToolStripMenuItem});
            this.hesapToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.hesapToolStripMenuItem.Name = "hesapToolStripMenuItem";
            this.hesapToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.hesapToolStripMenuItem.Text = "Hesap";
            // 
            // hesapÖzetiToolStripMenuItem
            // 
            this.hesapÖzetiToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.hesapÖzetiToolStripMenuItem.Name = "hesapÖzetiToolStripMenuItem";
            this.hesapÖzetiToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.hesapÖzetiToolStripMenuItem.Text = "Hesap Özeti";
            this.hesapÖzetiToolStripMenuItem.Click += new System.EventHandler(this.hesapÖzetiToolStripMenuItem_Click);
            // 
            // hesapSilToolStripMenuItem
            // 
            this.hesapSilToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.hesapSilToolStripMenuItem.Name = "hesapSilToolStripMenuItem";
            this.hesapSilToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.hesapSilToolStripMenuItem.Text = "Hesap Sil";
            this.hesapSilToolStripMenuItem.Click += new System.EventHandler(this.hesapSilToolStripMenuItem_Click);
            // 
            // paraİşlemleriToolStripMenuItem
            // 
            this.paraİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekmeToolStripMenuItem,
            this.paraYatırmaToolStripMenuItem,
            this.paraHavaleToolStripMenuItem});
            this.paraİşlemleriToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.paraİşlemleriToolStripMenuItem.Name = "paraİşlemleriToolStripMenuItem";
            this.paraİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.paraİşlemleriToolStripMenuItem.Text = "Para İşlemleri";
            // 
            // paraÇekmeToolStripMenuItem
            // 
            this.paraÇekmeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.paraÇekmeToolStripMenuItem.Name = "paraÇekmeToolStripMenuItem";
            this.paraÇekmeToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.paraÇekmeToolStripMenuItem.Text = "Para Çekme";
            this.paraÇekmeToolStripMenuItem.Click += new System.EventHandler(this.paraÇekmeToolStripMenuItem_Click);
            // 
            // paraYatırmaToolStripMenuItem
            // 
            this.paraYatırmaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.paraYatırmaToolStripMenuItem.Name = "paraYatırmaToolStripMenuItem";
            this.paraYatırmaToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.paraYatırmaToolStripMenuItem.Text = "Para Yatırma";
            this.paraYatırmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatırmaToolStripMenuItem_Click);
            // 
            // paraHavaleToolStripMenuItem
            // 
            this.paraHavaleToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.paraHavaleToolStripMenuItem.Name = "paraHavaleToolStripMenuItem";
            this.paraHavaleToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.paraHavaleToolStripMenuItem.Text = "Para Havale";
            this.paraHavaleToolStripMenuItem.Click += new System.EventHandler(this.paraHavaleToolStripMenuItem_Click);
            // 
            // lblHesapBilgileri
            // 
            this.lblHesapBilgileri.AutoSize = true;
            this.lblHesapBilgileri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblHesapBilgileri.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHesapBilgileri.Location = new System.Drawing.Point(12, 127);
            this.lblHesapBilgileri.Name = "lblHesapBilgileri";
            this.lblHesapBilgileri.Size = new System.Drawing.Size(99, 19);
            this.lblHesapBilgileri.TabIndex = 10;
            this.lblHesapBilgileri.Text = "Hesap Bilgileri";
            // 
            // FormHesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblHesapBilgileri);
            this.Name = "FormHesap";
            this.Text = "Hesap İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormHesap_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iŞLEMMENÜSÜToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapÖzetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraHavaleToolStripMenuItem;
        private System.Windows.Forms.Label lblHesapBilgileri;
    }
}