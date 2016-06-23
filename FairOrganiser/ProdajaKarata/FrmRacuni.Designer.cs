namespace ProdajaKarata
{
    partial class FrmRacuni
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
            this.dgvPopisRacuna = new System.Windows.Forms.DataGridView();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.racunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operaterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivKupcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadajidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRacuna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPopisRacuna
            // 
            this.dgvPopisRacuna.AllowUserToAddRows = false;
            this.dgvPopisRacuna.AllowUserToDeleteRows = false;
            this.dgvPopisRacuna.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPopisRacuna.AutoGenerateColumns = false;
            this.dgvPopisRacuna.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisRacuna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisRacuna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.operaterDataGridViewTextBoxColumn,
            this.vrijemeDataGridViewTextBoxColumn,
            this.ukupnoDataGridViewTextBoxColumn,
            this.nazivKupcaDataGridViewTextBoxColumn,
            this.zaposlenikidDataGridViewTextBoxColumn,
            this.dogadajidDataGridViewTextBoxColumn,
            this.dogadajDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.uslugasDataGridViewTextBoxColumn});
            this.dgvPopisRacuna.DataSource = this.racunBindingSource;
            this.dgvPopisRacuna.Location = new System.Drawing.Point(12, 12);
            this.dgvPopisRacuna.Name = "dgvPopisRacuna";
            this.dgvPopisRacuna.ReadOnly = true;
            this.dgvPopisRacuna.RowHeadersVisible = false;
            this.dgvPopisRacuna.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPopisRacuna.Size = new System.Drawing.Size(579, 323);
            this.dgvPopisRacuna.TabIndex = 0;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdaberi.Location = new System.Drawing.Point(426, 341);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(84, 23);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi račun";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzlaz.Location = new System.Drawing.Point(516, 341);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // racunBindingSource
            // 
            this.racunBindingSource.DataSource = typeof(ProdajaKarata.Racun);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // operaterDataGridViewTextBoxColumn
            // 
            this.operaterDataGridViewTextBoxColumn.DataPropertyName = "operater";
            this.operaterDataGridViewTextBoxColumn.HeaderText = "Operater";
            this.operaterDataGridViewTextBoxColumn.Name = "operaterDataGridViewTextBoxColumn";
            this.operaterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijemeDataGridViewTextBoxColumn
            // 
            this.vrijemeDataGridViewTextBoxColumn.DataPropertyName = "vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.HeaderText = "Vrijeme";
            this.vrijemeDataGridViewTextBoxColumn.Name = "vrijemeDataGridViewTextBoxColumn";
            this.vrijemeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukupnoDataGridViewTextBoxColumn
            // 
            this.ukupnoDataGridViewTextBoxColumn.DataPropertyName = "ukupno";
            this.ukupnoDataGridViewTextBoxColumn.HeaderText = "Ukupno";
            this.ukupnoDataGridViewTextBoxColumn.Name = "ukupnoDataGridViewTextBoxColumn";
            this.ukupnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivKupcaDataGridViewTextBoxColumn
            // 
            this.nazivKupcaDataGridViewTextBoxColumn.DataPropertyName = "nazivKupca";
            this.nazivKupcaDataGridViewTextBoxColumn.HeaderText = "Naziv kupca";
            this.nazivKupcaDataGridViewTextBoxColumn.Name = "nazivKupcaDataGridViewTextBoxColumn";
            this.nazivKupcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposlenikidDataGridViewTextBoxColumn
            // 
            this.zaposlenikidDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenikid";
            this.zaposlenikidDataGridViewTextBoxColumn.HeaderText = "Zaposlenikid";
            this.zaposlenikidDataGridViewTextBoxColumn.Name = "zaposlenikidDataGridViewTextBoxColumn";
            this.zaposlenikidDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dogadajidDataGridViewTextBoxColumn
            // 
            this.dogadajidDataGridViewTextBoxColumn.DataPropertyName = "Dogadajid";
            this.dogadajidDataGridViewTextBoxColumn.HeaderText = "Dogadajid";
            this.dogadajidDataGridViewTextBoxColumn.Name = "dogadajidDataGridViewTextBoxColumn";
            this.dogadajidDataGridViewTextBoxColumn.ReadOnly = true;
            this.dogadajidDataGridViewTextBoxColumn.Visible = false;
            // 
            // dogadajDataGridViewTextBoxColumn
            // 
            this.dogadajDataGridViewTextBoxColumn.DataPropertyName = "Dogadaj";
            this.dogadajDataGridViewTextBoxColumn.HeaderText = "Dogadaj";
            this.dogadajDataGridViewTextBoxColumn.Name = "dogadajDataGridViewTextBoxColumn";
            this.dogadajDataGridViewTextBoxColumn.ReadOnly = true;
            this.dogadajDataGridViewTextBoxColumn.Visible = false;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            this.zaposlenikDataGridViewTextBoxColumn.Visible = false;
            // 
            // uslugasDataGridViewTextBoxColumn
            // 
            this.uslugasDataGridViewTextBoxColumn.DataPropertyName = "Uslugas";
            this.uslugasDataGridViewTextBoxColumn.HeaderText = "Uslugas";
            this.uslugasDataGridViewTextBoxColumn.Name = "uslugasDataGridViewTextBoxColumn";
            this.uslugasDataGridViewTextBoxColumn.ReadOnly = true;
            this.uslugasDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmRacuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 373);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.dgvPopisRacuna);
            this.Name = "FrmRacuni";
            this.Text = "FrmRacuni";
            this.Load += new System.EventHandler(this.FrmRacuni_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisRacuna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racunBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPopisRacuna;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource racunBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operaterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivKupcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogadajidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogadajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uslugasDataGridViewTextBoxColumn;
    }
}