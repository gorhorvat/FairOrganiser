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
            this.lblValuta = new System.Windows.Forms.Label();
            this.txtSifraKarte = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.dgvPopisTipova = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPopisDogadaja = new System.Windows.Forms.DataGridView();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.lblTipkarte = new System.Windows.Forms.Label();
            this.lblCijenaKarte = new System.Windows.Forms.Label();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTipova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDogadaja)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(404, 18);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(22, 13);
            this.lblValuta.TabIndex = 27;
            this.lblValuta.Text = "KN";
            // 
            // txtSifraKarte
            // 
            this.txtSifraKarte.Location = new System.Drawing.Point(106, 12);
            this.txtSifraKarte.Name = "txtSifraKarte";
            this.txtSifraKarte.ReadOnly = true;
            this.txtSifraKarte.Size = new System.Drawing.Size(79, 20);
            this.txtSifraKarte.TabIndex = 26;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(18, 15);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(28, 13);
            this.lblSifra.TabIndex = 25;
            this.lblSifra.Text = "Šifra";
            // 
            // dgvPopisTipova
            // 
            this.dgvPopisTipova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisTipova.ColumnHeadersVisible = false;
            this.dgvPopisTipova.Location = new System.Drawing.Point(235, 100);
            this.dgvPopisTipova.Name = "dgvPopisTipova";
            this.dgvPopisTipova.RowHeadersVisible = false;
            this.dgvPopisTipova.Size = new System.Drawing.Size(114, 126);
            this.dgvPopisTipova.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Događaj";
            // 
            // dgvPopisDogadaja
            // 
            this.dgvPopisDogadaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisDogadaja.ColumnHeadersVisible = false;
            this.dgvPopisDogadaja.Location = new System.Drawing.Point(21, 100);
            this.dgvPopisDogadaja.Name = "dgvPopisDogadaja";
            this.dgvPopisDogadaja.RowHeadersVisible = false;
            this.dgvPopisDogadaja.Size = new System.Drawing.Size(149, 126);
            this.dgvPopisDogadaja.TabIndex = 22;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(392, 193);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(81, 33);
            this.btnIspisi.TabIndex = 21;
            this.btnIspisi.Text = "Ispis";
            this.btnIspisi.UseVisualStyleBackColor = true;
            // 
            // lblTipkarte
            // 
            this.lblTipkarte.AutoSize = true;
            this.lblTipkarte.Location = new System.Drawing.Point(232, 84);
            this.lblTipkarte.Name = "lblTipkarte";
            this.lblTipkarte.Size = new System.Drawing.Size(49, 13);
            this.lblTipkarte.TabIndex = 20;
            this.lblTipkarte.Text = "Tip karte";
            // 
            // lblCijenaKarte
            // 
            this.lblCijenaKarte.AutoSize = true;
            this.lblCijenaKarte.Location = new System.Drawing.Point(231, 18);
            this.lblCijenaKarte.Name = "lblCijenaKarte";
            this.lblCijenaKarte.Size = new System.Drawing.Size(66, 13);
            this.lblCijenaKarte.TabIndex = 19;
            this.lblCijenaKarte.Text = "Cijena karte:";
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.Location = new System.Drawing.Point(303, 15);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.ReadOnly = true;
            this.txtCijenaKarte.Size = new System.Drawing.Size(95, 20);
            this.txtCijenaKarte.TabIndex = 18;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(106, 38);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(144, 20);
            this.txtDatum.TabIndex = 17;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(18, 41);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(82, 13);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "Datum i vrijeme:";
            // 
            // FrmKarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 249);
            this.Controls.Add(this.lblValuta);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTipova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDogadaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.TextBox txtSifraKarte;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.DataGridView dgvPopisTipova;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPopisDogadaja;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.Label lblTipkarte;
        private System.Windows.Forms.Label lblCijenaKarte;
        private System.Windows.Forms.TextBox txtCijenaKarte;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label lblDatum;
    }
}