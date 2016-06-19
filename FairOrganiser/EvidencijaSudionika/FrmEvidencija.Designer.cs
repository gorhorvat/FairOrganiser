namespace EvidencijaSudionika
{
    partial class FrmEvidencija
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
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akreditacija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadajsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sudionikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudionici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudionikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzdajAkreditaciju
            // 
            this.btnIzdajAkreditaciju.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzdajAkreditaciju.Location = new System.Drawing.Point(529, 295);
            this.btnIzdajAkreditaciju.Name = "btnIzdajAkreditaciju";
            this.btnIzdajAkreditaciju.Size = new System.Drawing.Size(95, 35);
            this.btnIzdajAkreditaciju.TabIndex = 10;
            this.btnIzdajAkreditaciju.Text = "Izdaj akreditaciju";
            this.btnIzdajAkreditaciju.UseVisualStyleBackColor = true;
            this.btnIzdajAkreditaciju.Click += new System.EventHandler(this.btnIzdajAkreditaciju_Click);
            // 
            // btnIzbrisiSudionika
            // 
            this.btnIzbrisiSudionika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIzbrisiSudionika.Location = new System.Drawing.Point(431, 295);
            this.btnIzbrisiSudionika.Name = "btnIzbrisiSudionika";
            this.btnIzbrisiSudionika.Size = new System.Drawing.Size(92, 35);
            this.btnIzbrisiSudionika.TabIndex = 9;
            this.btnIzbrisiSudionika.Text = "Izbriši sudionika";
            this.btnIzbrisiSudionika.UseVisualStyleBackColor = true;
            this.btnIzbrisiSudionika.Click += new System.EventHandler(this.btnIzbrisiSudionika_Click);
            // 
            // btnDodajSudionika
            // 
            this.btnDodajSudionika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajSudionika.Location = new System.Drawing.Point(332, 295);
            this.btnDodajSudionika.Name = "btnDodajSudionika";
            this.btnDodajSudionika.Size = new System.Drawing.Size(93, 35);
            this.btnDodajSudionika.TabIndex = 8;
            this.btnDodajSudionika.Text = "Dodaj sudionika";
            this.btnDodajSudionika.UseVisualStyleBackColor = true;
            this.btnDodajSudionika.Click += new System.EventHandler(this.btnDodajSudionika_Click);
            // 
            // dgvSudionici
            // 
            this.dgvSudionici.AllowUserToAddRows = false;
            this.dgvSudionici.AllowUserToDeleteRows = false;
            this.dgvSudionici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSudionici.AutoGenerateColumns = false;
            this.dgvSudionici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSudionici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudionici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ime,
            this.prezime,
            this.telefon,
            this.email,
            this.dogadaj,
            this.akreditacija,
            this.dogadajsDataGridViewTextBoxColumn});
            this.dgvSudionici.DataSource = this.sudionikBindingSource;
            this.dgvSudionici.Location = new System.Drawing.Point(12, 38);
            this.dgvSudionici.Name = "dgvSudionici";
            this.dgvSudionici.ReadOnly = true;
            this.dgvSudionici.RowHeadersVisible = false;
            this.dgvSudionici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSudionici.Size = new System.Drawing.Size(612, 251);
            this.dgvSudionici.TabIndex = 7;
            // 
            // ime
            // 
            this.ime.DataPropertyName = "ime";
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            // 
            // prezime
            // 
            this.prezime.DataPropertyName = "prezime";
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // dogadaj
            // 
            this.dogadaj.DataPropertyName = "dogadaj";
            this.dogadaj.HeaderText = "Događaj";
            this.dogadaj.Name = "dogadaj";
            this.dogadaj.ReadOnly = true;
            // 
            // akreditacija
            // 
            this.akreditacija.DataPropertyName = "akreditacija";
            this.akreditacija.HeaderText = "Akreditacija";
            this.akreditacija.Name = "akreditacija";
            this.akreditacija.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Popis sudionika";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dogadajsDataGridViewTextBoxColumn
            // 
            this.dogadajsDataGridViewTextBoxColumn.DataPropertyName = "Dogadajs";
            this.dogadajsDataGridViewTextBoxColumn.HeaderText = "Dogadajs";
            this.dogadajsDataGridViewTextBoxColumn.Name = "dogadajsDataGridViewTextBoxColumn";
            this.dogadajsDataGridViewTextBoxColumn.ReadOnly = true;
            this.dogadajsDataGridViewTextBoxColumn.Visible = false;
            // 
            // sudionikBindingSource
            // 
            this.sudionikBindingSource.DataSource = typeof(EvidencijaSudionika.Sudionik);
            // 
            // FrmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIzdajAkreditaciju);
            this.Controls.Add(this.btnIzbrisiSudionika);
            this.Controls.Add(this.btnDodajSudionika);
            this.Controls.Add(this.dgvSudionici);
            this.Name = "FrmEvidencija";
            this.Text = "Sudionici";
            this.Load += new System.EventHandler(this.FrmSudionik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudionici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudionikBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIzdajAkreditaciju;
        private System.Windows.Forms.Button btnIzbrisiSudionika;
        private System.Windows.Forms.Button btnDodajSudionika;
        private System.Windows.Forms.DataGridView dgvSudionici;
        private System.Windows.Forms.BindingSource sudionikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogadaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn akreditacija;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogadajsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

