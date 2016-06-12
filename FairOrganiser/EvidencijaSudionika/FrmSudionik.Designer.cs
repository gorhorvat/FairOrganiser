namespace EvidencijaSudionika
{
    partial class FrmSudionik
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
            this.btnIzdajAkreditaciju = new System.Windows.Forms.Button();
            this.btnIzbrisiSudionika = new System.Windows.Forms.Button();
            this.btnDodajSudionika = new System.Windows.Forms.Button();
            this.dgvSudionici = new System.Windows.Forms.DataGridView();
            this.sudionikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medijskaKuca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akreditacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadajsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudionici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudionikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzdajAkreditaciju
            // 
            this.btnIzdajAkreditaciju.Location = new System.Drawing.Point(545, 295);
            this.btnIzdajAkreditaciju.Name = "btnIzdajAkreditaciju";
            this.btnIzdajAkreditaciju.Size = new System.Drawing.Size(79, 35);
            this.btnIzdajAkreditaciju.TabIndex = 10;
            this.btnIzdajAkreditaciju.Text = "Izdaj akreditaciju";
            this.btnIzdajAkreditaciju.UseVisualStyleBackColor = true;
            this.btnIzdajAkreditaciju.Click += new System.EventHandler(this.btnIzdajAkreditaciju_Click);
            // 
            // btnIzbrisiSudionika
            // 
            this.btnIzbrisiSudionika.Location = new System.Drawing.Point(469, 295);
            this.btnIzbrisiSudionika.Name = "btnIzbrisiSudionika";
            this.btnIzbrisiSudionika.Size = new System.Drawing.Size(70, 35);
            this.btnIzbrisiSudionika.TabIndex = 9;
            this.btnIzbrisiSudionika.Text = "Izbriši sudionika";
            this.btnIzbrisiSudionika.UseVisualStyleBackColor = true;
            this.btnIzbrisiSudionika.Click += new System.EventHandler(this.btnIzbrisiSudionika_Click);
            // 
            // btnDodajSudionika
            // 
            this.btnDodajSudionika.Location = new System.Drawing.Point(394, 295);
            this.btnDodajSudionika.Name = "btnDodajSudionika";
            this.btnDodajSudionika.Size = new System.Drawing.Size(69, 35);
            this.btnDodajSudionika.TabIndex = 8;
            this.btnDodajSudionika.Text = "Dodaj sudionika";
            this.btnDodajSudionika.UseVisualStyleBackColor = true;
            this.btnDodajSudionika.Click += new System.EventHandler(this.btnDodajSudionika_Click);
            // 
            // dgvSudionici
            // 
            this.dgvSudionici.AllowUserToAddRows = false;
            this.dgvSudionici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSudionici.AutoGenerateColumns = false;
            this.dgvSudionici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSudionici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudionici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.medijskaKuca,
            this.telefon,
            this.email,
            this.dogadaj,
            this.akreditacija,
            this.dogadajsDataGridViewTextBoxColumn});
            this.dgvSudionici.DataSource = this.sudionikBindingSource;
            this.dgvSudionici.Location = new System.Drawing.Point(18, 12);
            this.dgvSudionici.Name = "dgvSudionici";
            this.dgvSudionici.ReadOnly = true;
            this.dgvSudionici.RowHeadersVisible = false;
            this.dgvSudionici.Size = new System.Drawing.Size(606, 277);
            this.dgvSudionici.TabIndex = 7;
            // 
            // sudionikBindingSource
            // 
            this.sudionikBindingSource.DataSource = typeof(EvidencijaSudionika.Sudionik);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medijskaKuca
            // 
            this.medijskaKuca.DataPropertyName = "medijskaKuca";
            this.medijskaKuca.HeaderText = "medijskaKuca";
            this.medijskaKuca.Name = "medijskaKuca";
            this.medijskaKuca.ReadOnly = true;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // dogadaj
            // 
            this.dogadaj.DataPropertyName = "dogadaj";
            this.dogadaj.HeaderText = "dogadaj";
            this.dogadaj.Name = "dogadaj";
            this.dogadaj.ReadOnly = true;
            // 
            // akreditacija
            // 
            this.akreditacija.DataPropertyName = "akreditacija";
            this.akreditacija.HeaderText = "akreditacija";
            this.akreditacija.Name = "akreditacija";
            this.akreditacija.ReadOnly = true;
            this.akreditacija.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dogadajsDataGridViewTextBoxColumn
            // 
            this.dogadajsDataGridViewTextBoxColumn.DataPropertyName = "Dogadajs";
            this.dogadajsDataGridViewTextBoxColumn.HeaderText = "Dogadajs";
            this.dogadajsDataGridViewTextBoxColumn.Name = "dogadajsDataGridViewTextBoxColumn";
            this.dogadajsDataGridViewTextBoxColumn.ReadOnly = true;
            this.dogadajsDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmSudionik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 342);
            this.Controls.Add(this.btnIzdajAkreditaciju);
            this.Controls.Add(this.btnIzbrisiSudionika);
            this.Controls.Add(this.btnDodajSudionika);
            this.Controls.Add(this.dgvSudionici);
            this.Name = "FrmSudionik";
            this.Text = "Sudionici";
            this.Load += new System.EventHandler(this.FrmSudionik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudionici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudionikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzdajAkreditaciju;
        private System.Windows.Forms.Button btnIzbrisiSudionika;
        private System.Windows.Forms.Button btnDodajSudionika;
        private System.Windows.Forms.DataGridView dgvSudionici;
        private System.Windows.Forms.BindingSource sudionikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medijskaKuca;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogadaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn akreditacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogadajsDataGridViewTextBoxColumn;
    }
}

