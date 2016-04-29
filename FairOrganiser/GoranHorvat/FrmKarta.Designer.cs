namespace GoranHorvat
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
            this.lblBrKarte = new System.Windows.Forms.Label();
            this.txtBrojKarte = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.cmbDogadaj = new System.Windows.Forms.ComboBox();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.lblCijenaKarte = new System.Windows.Forms.Label();
            this.lblTipkarte = new System.Windows.Forms.Label();
            this.cmbTipKarte = new System.Windows.Forms.ComboBox();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrKarte
            // 
            this.lblBrKarte.AutoSize = true;
            this.lblBrKarte.Location = new System.Drawing.Point(22, 28);
            this.lblBrKarte.Name = "lblBrKarte";
            this.lblBrKarte.Size = new System.Drawing.Size(55, 13);
            this.lblBrKarte.TabIndex = 0;
            this.lblBrKarte.Text = "Broj karte:";
            // 
            // txtBrojKarte
            // 
            this.txtBrojKarte.Location = new System.Drawing.Point(110, 25);
            this.txtBrojKarte.Name = "txtBrojKarte";
            this.txtBrojKarte.ReadOnly = true;
            this.txtBrojKarte.Size = new System.Drawing.Size(79, 20);
            this.txtBrojKarte.TabIndex = 1;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(22, 69);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(82, 13);
            this.lblDatum.TabIndex = 2;
            this.lblDatum.Text = "Datum i vrijeme:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(110, 66);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(79, 20);
            this.txtDatum.TabIndex = 3;
            // 
            // cmbDogadaj
            // 
            this.cmbDogadaj.FormattingEnabled = true;
            this.cmbDogadaj.Location = new System.Drawing.Point(25, 124);
            this.cmbDogadaj.Name = "cmbDogadaj";
            this.cmbDogadaj.Size = new System.Drawing.Size(229, 21);
            this.cmbDogadaj.TabIndex = 4;
            this.cmbDogadaj.Text = "Odaberite događaj";
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.Location = new System.Drawing.Point(357, 124);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.ReadOnly = true;
            this.txtCijenaKarte.Size = new System.Drawing.Size(95, 20);
            this.txtCijenaKarte.TabIndex = 5;
            // 
            // lblCijenaKarte
            // 
            this.lblCijenaKarte.AutoSize = true;
            this.lblCijenaKarte.Location = new System.Drawing.Point(285, 127);
            this.lblCijenaKarte.Name = "lblCijenaKarte";
            this.lblCijenaKarte.Size = new System.Drawing.Size(66, 13);
            this.lblCijenaKarte.TabIndex = 6;
            this.lblCijenaKarte.Text = "Cijena karte:";
            // 
            // lblTipkarte
            // 
            this.lblTipkarte.AutoSize = true;
            this.lblTipkarte.Location = new System.Drawing.Point(285, 157);
            this.lblTipkarte.Name = "lblTipkarte";
            this.lblTipkarte.Size = new System.Drawing.Size(52, 13);
            this.lblTipkarte.TabIndex = 7;
            this.lblTipkarte.Text = "Tip karte:";
            // 
            // cmbTipKarte
            // 
            this.cmbTipKarte.FormattingEnabled = true;
            this.cmbTipKarte.Location = new System.Drawing.Point(357, 154);
            this.cmbTipKarte.Name = "cmbTipKarte";
            this.cmbTipKarte.Size = new System.Drawing.Size(95, 21);
            this.cmbTipKarte.TabIndex = 8;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(470, 185);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(81, 33);
            this.btnIspisi.TabIndex = 9;
            this.btnIspisi.Text = "Ispis";
            this.btnIspisi.UseVisualStyleBackColor = true;
            // 
            // FrmKarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 230);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.cmbTipKarte);
            this.Controls.Add(this.lblTipkarte);
            this.Controls.Add(this.lblCijenaKarte);
            this.Controls.Add(this.txtCijenaKarte);
            this.Controls.Add(this.cmbDogadaj);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.txtBrojKarte);
            this.Controls.Add(this.lblBrKarte);
            this.Name = "FrmKarta";
            this.Text = "FrmKarta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrKarte;
        private System.Windows.Forms.TextBox txtBrojKarte;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.ComboBox cmbDogadaj;
        private System.Windows.Forms.TextBox txtCijenaKarte;
        private System.Windows.Forms.Label lblCijenaKarte;
        private System.Windows.Forms.Label lblTipkarte;
        private System.Windows.Forms.ComboBox cmbTipKarte;
        private System.Windows.Forms.Button btnIspisi;
    }
}