namespace BankaYazilimOtomasyonu
{
    partial class FormBanka
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
			this.btnGeri = new System.Windows.Forms.Button();
			this.dataGelirGider = new System.Windows.Forms.DataGridView();
			this.gelir = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gider = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bankaBakiyesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGelirGider)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGeri
			// 
			this.btnGeri.BackColor = System.Drawing.Color.MintCream;
			this.btnGeri.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.btnGeri.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.btnGeri.Location = new System.Drawing.Point(138, 258);
			this.btnGeri.Name = "btnGeri";
			this.btnGeri.Size = new System.Drawing.Size(75, 26);
			this.btnGeri.TabIndex = 5;
			this.btnGeri.Text = "GERİ";
			this.btnGeri.UseVisualStyleBackColor = false;
			this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
			// 
			// dataGelirGider
			// 
			this.dataGelirGider.AllowUserToAddRows = false;
			this.dataGelirGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGelirGider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gelir,
            this.gider,
            this.bankaBakiyesi});
			this.dataGelirGider.Location = new System.Drawing.Point(12, 12);
			this.dataGelirGider.Name = "dataGelirGider";
			this.dataGelirGider.Size = new System.Drawing.Size(343, 227);
			this.dataGelirGider.TabIndex = 4;
			// 
			// gelir
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MintCream;
			this.gelir.DefaultCellStyle = dataGridViewCellStyle1;
			this.gelir.HeaderText = "Gelir";
			this.gelir.Name = "gelir";
			this.gelir.ReadOnly = true;
			// 
			// gider
			// 
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.MintCream;
			this.gider.DefaultCellStyle = dataGridViewCellStyle2;
			this.gider.HeaderText = "Gider";
			this.gider.Name = "gider";
			this.gider.ReadOnly = true;
			// 
			// bankaBakiyesi
			// 
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CadetBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.MintCream;
			this.bankaBakiyesi.DefaultCellStyle = dataGridViewCellStyle3;
			this.bankaBakiyesi.HeaderText = "Banka Bakiyesi";
			this.bankaBakiyesi.Name = "bankaBakiyesi";
			this.bankaBakiyesi.ReadOnly = true;
			// 
			// FormBanka
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(370, 293);
			this.Controls.Add(this.btnGeri);
			this.Controls.Add(this.dataGelirGider);
			this.Name = "FormBanka";
			this.Text = "Banka";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormBanka_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGelirGider)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.DataGridView dataGelirGider;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelir;
        private System.Windows.Forms.DataGridViewTextBoxColumn gider;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankaBakiyesi;
    }
}