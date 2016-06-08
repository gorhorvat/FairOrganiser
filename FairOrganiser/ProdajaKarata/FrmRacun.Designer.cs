namespace ProdajaKarata
{
    partial class FrmRacun
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
            this.btnObrisiStavku = new System.Windows.Forms.Button();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.dgvListaStavki = new System.Windows.Forms.DataGridView();
            this.btnIspisi = new System.Windows.Forms.Button();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtSjediste = new System.Windows.Forms.TextBox();
            this.txtNazivTvrtke = new System.Windows.Forms.TextBox();
            this.txtNazivKupca = new System.Windows.Forms.TextBox();
            this.lblNazivKupca = new System.Windows.Forms.Label();
            this.txtOperater = new System.Windows.Forms.TextBox();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.lblOperater = new System.Windows.Forms.Label();
            this.lblDatumiVrijeme = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStavki)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(141, 452);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(67, 36);
            this.btnObrisiStavku.TabIndex = 34;
            this.btnObrisiStavku.Text = "Obrisi stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(66, 452);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(69, 36);
            this.btnDodajStavku.TabIndex = 33;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            // 
            // dgvListaStavki
            // 
            this.dgvListaStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaStavki.Location = new System.Drawing.Point(66, 110);
            this.dgvListaStavki.Name = "dgvListaStavki";
            this.dgvListaStavki.Size = new System.Drawing.Size(550, 336);
            this.dgvListaStavki.TabIndex = 32;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(541, 483);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(75, 23);
            this.btnIspisi.TabIndex = 31;
            this.btnIspisi.Text = "Ispis";
            this.btnIspisi.UseVisualStyleBackColor = true;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(516, 452);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(100, 20);
            this.txtUkupno.TabIndex = 30;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(462, 455);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(48, 13);
            this.lblUkupno.TabIndex = 29;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(516, 84);
            this.txtOib.Name = "txtOib";
            this.txtOib.ReadOnly = true;
            this.txtOib.Size = new System.Drawing.Size(100, 20);
            this.txtOib.TabIndex = 28;
            // 
            // txtSjediste
            // 
            this.txtSjediste.Location = new System.Drawing.Point(516, 52);
            this.txtSjediste.Name = "txtSjediste";
            this.txtSjediste.ReadOnly = true;
            this.txtSjediste.Size = new System.Drawing.Size(100, 20);
            this.txtSjediste.TabIndex = 27;
            // 
            // txtNazivTvrtke
            // 
            this.txtNazivTvrtke.Location = new System.Drawing.Point(516, 22);
            this.txtNazivTvrtke.Name = "txtNazivTvrtke";
            this.txtNazivTvrtke.ReadOnly = true;
            this.txtNazivTvrtke.Size = new System.Drawing.Size(100, 20);
            this.txtNazivTvrtke.TabIndex = 26;
            // 
            // txtNazivKupca
            // 
            this.txtNazivKupca.Location = new System.Drawing.Point(151, 81);
            this.txtNazivKupca.Name = "txtNazivKupca";
            this.txtNazivKupca.ReadOnly = true;
            this.txtNazivKupca.Size = new System.Drawing.Size(100, 20);
            this.txtNazivKupca.TabIndex = 25;
            // 
            // lblNazivKupca
            // 
            this.lblNazivKupca.AutoSize = true;
            this.lblNazivKupca.Location = new System.Drawing.Point(63, 84);
            this.lblNazivKupca.Name = "lblNazivKupca";
            this.lblNazivKupca.Size = new System.Drawing.Size(70, 13);
            this.lblNazivKupca.TabIndex = 24;
            this.lblNazivKupca.Text = "Naziv kupca:";
            // 
            // txtOperater
            // 
            this.txtOperater.Location = new System.Drawing.Point(388, 52);
            this.txtOperater.Name = "txtOperater";
            this.txtOperater.ReadOnly = true;
            this.txtOperater.Size = new System.Drawing.Size(100, 20);
            this.txtOperater.TabIndex = 23;
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.Location = new System.Drawing.Point(151, 52);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.ReadOnly = true;
            this.txtVrijeme.Size = new System.Drawing.Size(159, 20);
            this.txtVrijeme.TabIndex = 22;
            // 
            // lblOperater
            // 
            this.lblOperater.AutoSize = true;
            this.lblOperater.Location = new System.Drawing.Point(331, 55);
            this.lblOperater.Name = "lblOperater";
            this.lblOperater.Size = new System.Drawing.Size(51, 13);
            this.lblOperater.TabIndex = 21;
            this.lblOperater.Text = "Operater:";
            // 
            // lblDatumiVrijeme
            // 
            this.lblDatumiVrijeme.AutoSize = true;
            this.lblDatumiVrijeme.Location = new System.Drawing.Point(63, 55);
            this.lblDatumiVrijeme.Name = "lblDatumiVrijeme";
            this.lblDatumiVrijeme.Size = new System.Drawing.Size(82, 13);
            this.lblDatumiVrijeme.TabIndex = 20;
            this.lblDatumiVrijeme.Text = "Datum i vrijeme:";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.Location = new System.Drawing.Point(151, 21);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.ReadOnly = true;
            this.txtBrojRacuna.Size = new System.Drawing.Size(100, 20);
            this.txtBrojRacuna.TabIndex = 19;
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(63, 24);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(64, 13);
            this.lblBrojRacuna.TabIndex = 18;
            this.lblBrojRacuna.Text = "Broj racuna:";
            // 
            // FrmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 527);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dgvListaStavki);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.txtSjediste);
            this.Controls.Add(this.txtNazivTvrtke);
            this.Controls.Add(this.txtNazivKupca);
            this.Controls.Add(this.lblNazivKupca);
            this.Controls.Add(this.txtOperater);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.lblOperater);
            this.Controls.Add(this.lblDatumiVrijeme);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.lblBrojRacuna);
            this.Name = "FrmRacun";
            this.Text = "Račun";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStavki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiStavku;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.DataGridView dgvListaStavki;
        private System.Windows.Forms.Button btnIspisi;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.TextBox txtSjediste;
        private System.Windows.Forms.TextBox txtNazivTvrtke;
        private System.Windows.Forms.TextBox txtNazivKupca;
        private System.Windows.Forms.Label lblNazivKupca;
        private System.Windows.Forms.TextBox txtOperater;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.Label lblOperater;
        private System.Windows.Forms.Label lblDatumiVrijeme;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label lblBrojRacuna;
    }
}