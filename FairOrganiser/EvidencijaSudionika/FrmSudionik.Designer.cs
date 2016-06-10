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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogadajsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sudionikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSudionici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudionikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIzdajAkreditaciju
            // 
            this.btnIzdajAkreditaciju.Location = new System.Drawing.Point(417, 295);
            this.btnIzdajAkreditaciju.Name = "btnIzdajAkreditaciju";
            this.btnIzdajAkreditaciju.Size = new System.Drawing.Size(79, 35);
            this.btnIzdajAkreditaciju.TabIndex = 10;
            this.btnIzdajAkreditaciju.Text = "Izdaj akreditaciju";
            this.btnIzdajAkreditaciju.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiSudionika
            // 
            this.btnIzbrisiSudionika.Location = new System.Drawing.Point(341, 295);
            this.btnIzbrisiSudionika.Name = "btnIzbrisiSudionika";
            this.btnIzbrisiSudionika.Size = new System.Drawing.Size(70, 35);
            this.btnIzbrisiSudionika.TabIndex = 9;
            this.btnIzbrisiSudionika.Text = "Izbriši sudionika";
            this.btnIzbrisiSudionika.UseVisualStyleBackColor = true;
            this.btnIzbrisiSudionika.Click += new System.EventHandler(this.btnIzbrisiSudionika_Click);
            // 
            // btnDodajSudionika
            // 
            this.btnDodajSudionika.Location = new System.Drawing.Point(266, 295);
            this.btnDodajSudionika.Name = "btnDodajSudionika";
            this.btnDodajSudionika.Size = new System.Drawing.Size(69, 35);
            this.btnDodajSudionika.TabIndex = 8;
            this.btnDodajSudionika.Text = "Dodaj sudionika";
            this.btnDodajSudionika.UseVisualStyleBackColor = true;
            // 
            // dgvSudionici
            // 
            this.dgvSudionici.AutoGenerateColumns = false;
            this.dgvSudionici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSudionici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSudionici.ColumnHeadersVisible = false;
            this.dgvSudionici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.dogadajsDataGridViewTextBoxColumn});
            this.dgvSudionici.DataSource = this.sudionikBindingSource;
            this.dgvSudionici.Location = new System.Drawing.Point(18, 12);
            this.dgvSudionici.Name = "dgvSudionici";
            this.dgvSudionici.RowHeadersVisible = false;
            this.dgvSudionici.Size = new System.Drawing.Size(478, 277);
            this.dgvSudionici.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            // 
            // dogadajsDataGridViewTextBoxColumn
            // 
            this.dogadajsDataGridViewTextBoxColumn.DataPropertyName = "Dogadajs";
            this.dogadajsDataGridViewTextBoxColumn.HeaderText = "Dogadajs";
            this.dogadajsDataGridViewTextBoxColumn.Name = "dogadajsDataGridViewTextBoxColumn";
            this.dogadajsDataGridViewTextBoxColumn.Visible = false;
            // 
            // sudionikBindingSource
            // 
            this.sudionikBindingSource.DataSource = typeof(EvidencijaSudionika.Sudionik);
            // 
            // FrmSudionik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 342);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogadajsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sudionikBindingSource;
    }
}

