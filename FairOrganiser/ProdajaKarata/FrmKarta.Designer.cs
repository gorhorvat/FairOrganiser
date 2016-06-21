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
            this.components = new System.ComponentModel.Container();
            this.lblValuta = new System.Windows.Forms.Label();
            this.txtSifraKarte = new System.Windows.Forms.TextBox();
            this.lblSifra = new System.Windows.Forms.Label();
            this.dgvPopisTipova = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosPopustaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjenikDogadajaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjenikDogadajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipKarteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPopisDogadaja = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIspisi = new System.Windows.Forms.Button();
            this.lblTipkarte = new System.Windows.Forms.Label();
            this.lblCijenaKarte = new System.Windows.Forms.Label();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTipova)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipKarteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDogadaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Location = new System.Drawing.Point(360, 12);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(22, 13);
            this.lblValuta.TabIndex = 27;
            this.lblValuta.Text = "KN";
            // 
            // txtSifraKarte
            // 
            this.txtSifraKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSifraKarte.Location = new System.Drawing.Point(106, 12);
            this.txtSifraKarte.Name = "txtSifraKarte";
            this.txtSifraKarte.ReadOnly = true;
            this.txtSifraKarte.Size = new System.Drawing.Size(79, 20);
            this.txtSifraKarte.TabIndex = 26;
            // 
            // lblSifra
            // 
            this.lblSifra.AutoSize = true;
            this.lblSifra.Location = new System.Drawing.Point(18, 12);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(31, 13);
            this.lblSifra.TabIndex = 25;
            this.lblSifra.Text = "Šifra:";
            // 
            // dgvPopisTipova
            // 
            this.dgvPopisTipova.AllowUserToAddRows = false;
            this.dgvPopisTipova.AutoGenerateColumns = false;
            this.dgvPopisTipova.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisTipova.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisTipova.ColumnHeadersVisible = false;
            this.dgvPopisTipova.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.iznosPopustaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn1,
            this.cjenikDogadajaidDataGridViewTextBoxColumn,
            this.cjenikDogadajaDataGridViewTextBoxColumn});
            this.dgvPopisTipova.DataSource = this.tipKarteBindingSource;
            this.dgvPopisTipova.Location = new System.Drawing.Point(256, 100);
            this.dgvPopisTipova.Name = "dgvPopisTipova";
            this.dgvPopisTipova.ReadOnly = true;
            this.dgvPopisTipova.RowHeadersVisible = false;
            this.dgvPopisTipova.Size = new System.Drawing.Size(229, 126);
            this.dgvPopisTipova.TabIndex = 24;
            this.dgvPopisTipova.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisTipova_CellClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // iznosPopustaDataGridViewTextBoxColumn
            // 
            this.iznosPopustaDataGridViewTextBoxColumn.DataPropertyName = "iznosPopusta";
            this.iznosPopustaDataGridViewTextBoxColumn.HeaderText = "iznosPopusta";
            this.iznosPopustaDataGridViewTextBoxColumn.Name = "iznosPopustaDataGridViewTextBoxColumn";
            this.iznosPopustaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iznosPopustaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cjenikDogadajaidDataGridViewTextBoxColumn
            // 
            this.cjenikDogadajaidDataGridViewTextBoxColumn.DataPropertyName = "CjenikDogadajaid";
            this.cjenikDogadajaidDataGridViewTextBoxColumn.HeaderText = "CjenikDogadajaid";
            this.cjenikDogadajaidDataGridViewTextBoxColumn.Name = "cjenikDogadajaidDataGridViewTextBoxColumn";
            this.cjenikDogadajaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cjenikDogadajaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // cjenikDogadajaDataGridViewTextBoxColumn
            // 
            this.cjenikDogadajaDataGridViewTextBoxColumn.DataPropertyName = "CjenikDogadaja";
            this.cjenikDogadajaDataGridViewTextBoxColumn.HeaderText = "CjenikDogadaja";
            this.cjenikDogadajaDataGridViewTextBoxColumn.Name = "cjenikDogadajaDataGridViewTextBoxColumn";
            this.cjenikDogadajaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cjenikDogadajaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipKarteBindingSource
            // 
            this.tipKarteBindingSource.DataSource = typeof(ProdajaKarata.TipKarte);
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
            this.dgvPopisDogadaja.AllowUserToAddRows = false;
            this.dgvPopisDogadaja.AutoGenerateColumns = false;
            this.dgvPopisDogadaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisDogadaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisDogadaja.ColumnHeadersVisible = false;
            this.dgvPopisDogadaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.datumOdDataGridViewTextBoxColumn,
            this.datumDoDataGridViewTextBoxColumn,
            this.cijenaKarteDataGridViewTextBoxColumn,
            this.kartasDataGridViewTextBoxColumn,
            this.racunsDataGridViewTextBoxColumn});
            this.dgvPopisDogadaja.DataSource = this.dogadajBindingSource;
            this.dgvPopisDogadaja.Location = new System.Drawing.Point(21, 100);
            this.dgvPopisDogadaja.Name = "dgvPopisDogadaja";
            this.dgvPopisDogadaja.ReadOnly = true;
            this.dgvPopisDogadaja.RowHeadersVisible = false;
            this.dgvPopisDogadaja.Size = new System.Drawing.Size(229, 126);
            this.dgvPopisDogadaja.TabIndex = 22;
            this.dgvPopisDogadaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPopisDogadaja_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumOdDataGridViewTextBoxColumn
            // 
            this.datumOdDataGridViewTextBoxColumn.DataPropertyName = "datumOd";
            this.datumOdDataGridViewTextBoxColumn.HeaderText = "datumOd";
            this.datumOdDataGridViewTextBoxColumn.Name = "datumOdDataGridViewTextBoxColumn";
            this.datumOdDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumOdDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumDoDataGridViewTextBoxColumn
            // 
            this.datumDoDataGridViewTextBoxColumn.DataPropertyName = "datumDo";
            this.datumDoDataGridViewTextBoxColumn.HeaderText = "datumDo";
            this.datumDoDataGridViewTextBoxColumn.Name = "datumDoDataGridViewTextBoxColumn";
            this.datumDoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaKarteDataGridViewTextBoxColumn
            // 
            this.cijenaKarteDataGridViewTextBoxColumn.DataPropertyName = "cijenaKarte";
            this.cijenaKarteDataGridViewTextBoxColumn.HeaderText = "cijenaKarte";
            this.cijenaKarteDataGridViewTextBoxColumn.Name = "cijenaKarteDataGridViewTextBoxColumn";
            this.cijenaKarteDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaKarteDataGridViewTextBoxColumn.Visible = false;
            // 
            // kartasDataGridViewTextBoxColumn
            // 
            this.kartasDataGridViewTextBoxColumn.DataPropertyName = "Kartas";
            this.kartasDataGridViewTextBoxColumn.HeaderText = "Kartas";
            this.kartasDataGridViewTextBoxColumn.Name = "kartasDataGridViewTextBoxColumn";
            this.kartasDataGridViewTextBoxColumn.ReadOnly = true;
            this.kartasDataGridViewTextBoxColumn.Visible = false;
            // 
            // racunsDataGridViewTextBoxColumn
            // 
            this.racunsDataGridViewTextBoxColumn.DataPropertyName = "Racuns";
            this.racunsDataGridViewTextBoxColumn.HeaderText = "Racuns";
            this.racunsDataGridViewTextBoxColumn.Name = "racunsDataGridViewTextBoxColumn";
            this.racunsDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunsDataGridViewTextBoxColumn.Visible = false;
            // 
            // dogadajBindingSource
            // 
            this.dogadajBindingSource.DataSource = typeof(ProdajaKarata.Dogadaj);
            // 
            // btnIspisi
            // 
            this.btnIspisi.Location = new System.Drawing.Point(386, 232);
            this.btnIspisi.Name = "btnIspisi";
            this.btnIspisi.Size = new System.Drawing.Size(100, 33);
            this.btnIspisi.TabIndex = 21;
            this.btnIspisi.Text = "Ispis";
            this.btnIspisi.UseVisualStyleBackColor = true;
            this.btnIspisi.Click += new System.EventHandler(this.btnIspisi_Click);
            // 
            // lblTipkarte
            // 
            this.lblTipkarte.AutoSize = true;
            this.lblTipkarte.Location = new System.Drawing.Point(256, 84);
            this.lblTipkarte.Name = "lblTipkarte";
            this.lblTipkarte.Size = new System.Drawing.Size(49, 13);
            this.lblTipkarte.TabIndex = 20;
            this.lblTipkarte.Text = "Tip karte";
            // 
            // lblCijenaKarte
            // 
            this.lblCijenaKarte.AutoSize = true;
            this.lblCijenaKarte.Location = new System.Drawing.Point(231, 12);
            this.lblCijenaKarte.Name = "lblCijenaKarte";
            this.lblCijenaKarte.Size = new System.Drawing.Size(66, 13);
            this.lblCijenaKarte.TabIndex = 19;
            this.lblCijenaKarte.Text = "Cijena karte:";
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCijenaKarte.Location = new System.Drawing.Point(303, 12);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.ReadOnly = true;
            this.txtCijenaKarte.Size = new System.Drawing.Size(51, 20);
            this.txtCijenaKarte.TabIndex = 18;
            // 
            // txtDatum
            // 
            this.txtDatum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatum.Location = new System.Drawing.Point(106, 38);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(144, 20);
            this.txtDatum.TabIndex = 17;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(18, 38);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(82, 13);
            this.lblDatum.TabIndex = 16;
            this.lblDatum.Text = "Datum i vrijeme:";
            // 
            // FrmKarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 291);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmKarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisTipova)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipKarteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisDogadaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dogadajBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosPopustaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjenikDogadajaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjenikDogadajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipKarteBindingSource;
    }
}