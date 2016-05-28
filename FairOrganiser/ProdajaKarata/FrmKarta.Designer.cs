namespace ProdajaKarata
{
    partial class FrmKarta
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
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblTipkarte = new System.Windows.Forms.Label();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.lblCijenaKarte = new System.Windows.Forms.Label();
            this.dgvPopisDogadaja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPopisTipova = new System.Windows.Forms.DataGridView();
            this.txtSifraKarte = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDogadaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTipova)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(22, 55);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(82, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum i vrijeme:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(110, 52);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(144, 20);
            this.txtDatum.TabIndex = 3;
            // 
            // lblTipkarte
            // 
            this.lblTipkarte.AutoSize = true;
            this.lblTipkarte.Location = new System.Drawing.Point(236, 98);
            this.lblTipkarte.Name = "lblTipkarte";
            this.lblTipkarte.Size = new System.Drawing.Size(49, 13);
            this.lblTipkarte.TabIndex = 7;
            this.lblTipkarte.Text = "Tip karte";
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(396, 207);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(81, 33);
            this.btnIspisi.TabIndex = 9;
            this.btnIspisi.Text = "Ispis";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.Location = new System.Drawing.Point(307, 29);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.ReadOnly = true;
            this.txtCijenaKarte.Size = new System.Drawing.Size(95, 20);
            this.txtCijenaKarte.TabIndex = 5;
            // 
            // lblCijenaKarte
            // 
            this.lblCijenaKarte.AutoSize = true;
            this.lblCijenaKarte.Location = new System.Drawing.Point(235, 32);
            this.lblCijenaKarte.Name = "lblCijenaKarte";
            this.lblCijenaKarte.Size = new System.Drawing.Size(66, 13);
            this.lblCijenaKarte.TabIndex = 6;
            this.lblCijenaKarte.Text = "Cijena karte:";
            // 
            // dgvPopisDogadaja
            // 
            this.dgvPopisDogadaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisDogadaja.ColumnHeadersVisible = false;
            this.dgvPopisDogadaja.Location = new System.Drawing.Point(25, 114);
            this.dgvPopisDogadaja.Name = "dgvPopisDogadaja";
            this.dgvPopisDogadaja.RowHeadersVisible = false;
            this.dgvPopisDogadaja.Size = new System.Drawing.Size(149, 126);
            this.dgvPopisDogadaja.TabIndex = 10;
            this.dgvPopisDogadaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisDogadaja_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Događaj";
            // 
            // dgvPopisTipova
            // 
            this.dgvPopisTipova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisTipova.ColumnHeadersVisible = false;
            this.dgvPopisTipova.Location = new System.Drawing.Point(239, 114);
            this.dgvPopisTipova.Name = "dgvPopisTipova";
            this.dgvPopisTipova.RowHeadersVisible = false;
            this.dgvPopisTipova.Size = new System.Drawing.Size(114, 126);
            this.dgvPopisTipova.TabIndex = 12;
            this.dgvPopisTipova.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisTipova_CellClick);
            // 
            // txtSifraKarte
            // 
            this.txtSifraKarte.Location = new System.Drawing.Point(110, 26);
            this.txtSifraKarte.Name = "txtSifraKarte";
            this.txtSifraKarte.ReadOnly = true;
            this.txtSifraKarte.Size = new System.Drawing.Size(79, 20);
            this.txtSifraKarte.TabIndex = 14;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(22, 29);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 13;
            this.lblSifra.Text = "Šifra";
            // 
            // FrmKarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 254);
            this.Controls.Add(this.txtSifraKarte);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.dgvPopisTipova);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPopisDogadaja);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.lblTipkarte);
            this.Controls.Add(this.lblCijenaKarte);
            this.Controls.Add(this.txtCijenaKarte);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblDatum);
            this.Name = "FrmKarta";
            this.Text = "Karta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDogadaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTipova)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblTipkarte;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.TextBox txtCijenaKarte;
        private System.Windows.Forms.Label lblCijenaKarte;
        private System.Windows.Forms.DataGridView dgvPopisDogadaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopisTipova;
        private System.Windows.Forms.TextBox txtSifraKarte;
        private System.Windows.Forms.Label lblSifra;
    }
}