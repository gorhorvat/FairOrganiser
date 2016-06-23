namespace ProdajaKarata
{
    partial class FrmPrikazRacuna
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
            this.txtOTvrtci = new System.Windows.Forms.TextBox();
            this.txtNazivKupca = new System.Windows.Forms.TextBox();
            this.lblNazivKupca = new System.Windows.Forms.Label();
            this.txtOperater = new System.Windows.Forms.TextBox();
            this.txtVrijeme = new System.Windows.Forms.TextBox();
            this.lblOperater = new System.Windows.Forms.Label();
            this.lblDatumiVrijeme = new System.Windows.Forms.Label();
            this.txtBrojRacuna = new System.Windows.Forms.TextBox();
            this.lblBrojRacuna = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaStavki)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiStavku
            // 
            this.btnObrisiStavku.Location = new System.Drawing.Point(87, 479);
            this.btnObrisiStavku.Name = "btnObrisiStavku";
            this.btnObrisiStavku.Size = new System.Drawing.Size(67, 36);
            this.btnObrisiStavku.TabIndex = 34;
            this.btnObrisiStavku.Text = "Obrisi stavku";
            this.btnObrisiStavku.UseVisualStyleBackColor = true;
            this.btnObrisiStavku.Click += new System.EventHandler(this.btnObrisiStavku_Click);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(12, 479);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(69, 36);
            this.btnDodajStavku.TabIndex = 33;
            this.btnDodajStavku.Text = "Dodaj stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // dgvListaStavki
            // 
            this.dgvListaStavki.AllowUserToAddRows = false;
            this.dgvListaStavki.AllowUserToDeleteRows = false;
            this.dgvListaStavki.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaStavki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaStavki.Location = new System.Drawing.Point(12, 110);
            this.dgvListaStavki.Name = "dgvListaStavki";
            this.dgvListaStavki.ReadOnly = true;
            this.dgvListaStavki.RowHeadersVisible = false;
            this.dgvListaStavki.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaStavki.Size = new System.Drawing.Size(736, 336);
            this.dgvListaStavki.TabIndex = 32;
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(623, 479);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(125, 36);
            this.btnIspisi.TabIndex = 31;
            this.btnIspisi.Text = "Ispis";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // txtUkupno
            // 
            this.txtUkupno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUkupno.Location = new System.Drawing.Point(648, 453);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(73, 13);
            this.txtUkupno.TabIndex = 30;
            // 
            // lblUkupno
            // 
            this.lblUkupno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(594, 453);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(48, 13);
            this.lblUkupno.TabIndex = 29;
            this.lblUkupno.Text = "Ukupno:";
            // 
            // txtOTvrtci
            // 
            this.txtOTvrtci.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOTvrtci.Location = new System.Drawing.Point(516, 24);
            this.txtOTvrtci.Multiline = true;
            this.txtOTvrtci.Name = "txtOTvrtci";
            this.txtOTvrtci.ReadOnly = true;
            this.txtOTvrtci.Size = new System.Drawing.Size(232, 80);
            this.txtOTvrtci.TabIndex = 26;
            // 
            // txtNazivKupca
            // 
            this.txtNazivKupca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNazivKupca.Location = new System.Drawing.Point(151, 81);
            this.txtNazivKupca.Name = "txtNazivKupca";
            this.txtNazivKupca.ReadOnly = true;
            this.txtNazivKupca.Size = new System.Drawing.Size(100, 13);
            this.txtNazivKupca.TabIndex = 25;
            // 
            // lblNazivKupca
            // 
            this.lblNazivKupca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNazivKupca.AutoSize = true;
            this.lblNazivKupca.Location = new System.Drawing.Point(63, 81);
            this.lblNazivKupca.Name = "lblNazivKupca";
            this.lblNazivKupca.Size = new System.Drawing.Size(70, 13);
            this.lblNazivKupca.TabIndex = 24;
            this.lblNazivKupca.Text = "Naziv kupca:";
            // 
            // txtOperater
            // 
            this.txtOperater.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOperater.Location = new System.Drawing.Point(388, 52);
            this.txtOperater.Name = "txtOperater";
            this.txtOperater.ReadOnly = true;
            this.txtOperater.Size = new System.Drawing.Size(100, 13);
            this.txtOperater.TabIndex = 23;
            // 
            // txtVrijeme
            // 
            this.txtVrijeme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVrijeme.Location = new System.Drawing.Point(151, 52);
            this.txtVrijeme.Name = "txtVrijeme";
            this.txtVrijeme.ReadOnly = true;
            this.txtVrijeme.Size = new System.Drawing.Size(159, 13);
            this.txtVrijeme.TabIndex = 22;
            // 
            // lblOperater
            // 
            this.lblOperater.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOperater.AutoSize = true;
            this.lblOperater.Location = new System.Drawing.Point(331, 52);
            this.lblOperater.Name = "lblOperater";
            this.lblOperater.Size = new System.Drawing.Size(51, 13);
            this.lblOperater.TabIndex = 21;
            this.lblOperater.Text = "Operater:";
            // 
            // lblDatumiVrijeme
            // 
            this.lblDatumiVrijeme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDatumiVrijeme.AutoSize = true;
            this.lblDatumiVrijeme.Location = new System.Drawing.Point(63, 52);
            this.lblDatumiVrijeme.Name = "lblDatumiVrijeme";
            this.lblDatumiVrijeme.Size = new System.Drawing.Size(82, 13);
            this.lblDatumiVrijeme.TabIndex = 20;
            this.lblDatumiVrijeme.Text = "Datum i vrijeme:";
            // 
            // txtBrojRacuna
            // 
            this.txtBrojRacuna.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojRacuna.Location = new System.Drawing.Point(151, 21);
            this.txtBrojRacuna.Name = "txtBrojRacuna";
            this.txtBrojRacuna.ReadOnly = true;
            this.txtBrojRacuna.Size = new System.Drawing.Size(100, 13);
            this.txtBrojRacuna.TabIndex = 19;
            // 
            // lblBrojRacuna
            // 
            this.lblBrojRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrojRacuna.AutoSize = true;
            this.lblBrojRacuna.Location = new System.Drawing.Point(63, 21);
            this.lblBrojRacuna.Name = "lblBrojRacuna";
            this.lblBrojRacuna.Size = new System.Drawing.Size(64, 13);
            this.lblBrojRacuna.TabIndex = 18;
            this.lblBrojRacuna.Text = "Broj racuna:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "KN";
            // 
            // FrmPrikazRacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(760, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiStavku);
            this.Controls.Add(this.btnDodajStavku);
            this.Controls.Add(this.dgvListaStavki);
            this.Controls.Add(this.btnIspisi);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.txtOTvrtci);
            this.Controls.Add(this.txtNazivKupca);
            this.Controls.Add(this.lblNazivKupca);
            this.Controls.Add(this.txtOperater);
            this.Controls.Add(this.txtVrijeme);
            this.Controls.Add(this.lblOperater);
            this.Controls.Add(this.lblDatumiVrijeme);
            this.Controls.Add(this.txtBrojRacuna);
            this.Controls.Add(this.lblBrojRacuna);
            this.Name = "FrmPrikazRacuna";
            this.Text = "Prikaz računa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrikazRacuna_Load);
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
        private System.Windows.Forms.TextBox txtOTvrtci;
        private System.Windows.Forms.TextBox txtNazivKupca;
        private System.Windows.Forms.Label lblNazivKupca;
        private System.Windows.Forms.TextBox txtOperater;
        private System.Windows.Forms.TextBox txtVrijeme;
        private System.Windows.Forms.Label lblOperater;
        private System.Windows.Forms.Label lblDatumiVrijeme;
        private System.Windows.Forms.TextBox txtBrojRacuna;
        private System.Windows.Forms.Label lblBrojRacuna;
        private System.Windows.Forms.Label label1;
    }
}