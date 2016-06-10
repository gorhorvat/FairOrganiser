namespace ProdajaKarata
{
    partial class FrmCjenik
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
            this.btnPregledaj = new System.Windows.Forms.Button();
            this.dgvPopisCjenika = new System.Windows.Forms.DataGridView();
            this.btnObrisiCjenik = new System.Windows.Forms.Button();
            this.btnDodajCjenik = new System.Windows.Forms.Button();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.lblCjenikKarata = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijediOdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijediDoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kartasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipKartesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjenikDogadajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisCjenika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikDogadajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPregledaj
            // 
            this.btnPregledaj.Location = new System.Drawing.Point(203, 250);
            this.btnPregledaj.Name = "btnPregledaj";
            this.btnPregledaj.Size = new System.Drawing.Size(98, 23);
            this.btnPregledaj.TabIndex = 18;
            this.btnPregledaj.Text = "Pregledaj cjenik";
            this.btnPregledaj.UseVisualStyleBackColor = true;
            this.btnPregledaj.Click += new System.EventHandler(this.btnPregledaj_Click);
            // 
            // dgvPopisCjenika
            // 
            this.dgvPopisCjenika.AllowUserToAddRows = false;
            this.dgvPopisCjenika.AutoGenerateColumns = false;
            this.dgvPopisCjenika.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopisCjenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisCjenika.ColumnHeadersVisible = false;
            this.dgvPopisCjenika.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vrijediOdDataGridViewTextBoxColumn,
            this.vrijediDoDataGridViewTextBoxColumn,
            this.kartasDataGridViewTextBoxColumn,
            this.tipKartesDataGridViewTextBoxColumn});
            this.dgvPopisCjenika.DataSource = this.cjenikDogadajaBindingSource;
            this.dgvPopisCjenika.Location = new System.Drawing.Point(12, 54);
            this.dgvPopisCjenika.Name = "dgvPopisCjenika";
            this.dgvPopisCjenika.ReadOnly = true;
            this.dgvPopisCjenika.RowHeadersVisible = false;
            this.dgvPopisCjenika.Size = new System.Drawing.Size(503, 190);
            this.dgvPopisCjenika.TabIndex = 17;
            // 
            // btnObrisiCjenik
            // 
            this.btnObrisiCjenik.Location = new System.Drawing.Point(107, 250);
            this.btnObrisiCjenik.Name = "btnObrisiCjenik";
            this.btnObrisiCjenik.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiCjenik.TabIndex = 16;
            this.btnObrisiCjenik.Text = "Obriši cjenik";
            this.btnObrisiCjenik.UseVisualStyleBackColor = true;
            this.btnObrisiCjenik.Click += new System.EventHandler(this.btnObrisiCjenik_Click);
            // 
            // btnDodajCjenik
            // 
            this.btnDodajCjenik.Location = new System.Drawing.Point(12, 250);
            this.btnDodajCjenik.Name = "btnDodajCjenik";
            this.btnDodajCjenik.Size = new System.Drawing.Size(75, 23);
            this.btnDodajCjenik.TabIndex = 15;
            this.btnDodajCjenik.Text = "Dodaj cjenik";
            this.btnDodajCjenik.UseVisualStyleBackColor = true;
            this.btnDodajCjenik.Click += new System.EventHandler(this.btnDodajCjenik_Click);
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "";
            this.dtpDo.Location = new System.Drawing.Point(373, 12);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(142, 20);
            this.dtpDo.TabIndex = 14;
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "";
            this.dtpOd.Location = new System.Drawing.Point(203, 12);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(142, 20);
            this.dtpOd.TabIndex = 13;
            // 
            // lblCjenikKarata
            // 
            this.lblCjenikKarata.AutoSize = true;
            this.lblCjenikKarata.Location = new System.Drawing.Point(9, 38);
            this.lblCjenikKarata.Name = "lblCjenikKarata";
            this.lblCjenikKarata.Size = new System.Drawing.Size(69, 13);
            this.lblCjenikKarata.TabIndex = 12;
            this.lblCjenikKarata.Text = "Cjenik karata";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijediOdDataGridViewTextBoxColumn
            // 
            this.vrijediOdDataGridViewTextBoxColumn.DataPropertyName = "vrijediOd";
            this.vrijediOdDataGridViewTextBoxColumn.HeaderText = "vrijediOd";
            this.vrijediOdDataGridViewTextBoxColumn.Name = "vrijediOdDataGridViewTextBoxColumn";
            this.vrijediOdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijediDoDataGridViewTextBoxColumn
            // 
            this.vrijediDoDataGridViewTextBoxColumn.DataPropertyName = "vrijediDo";
            this.vrijediDoDataGridViewTextBoxColumn.HeaderText = "vrijediDo";
            this.vrijediDoDataGridViewTextBoxColumn.Name = "vrijediDoDataGridViewTextBoxColumn";
            this.vrijediDoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kartasDataGridViewTextBoxColumn
            // 
            this.kartasDataGridViewTextBoxColumn.DataPropertyName = "Kartas";
            this.kartasDataGridViewTextBoxColumn.HeaderText = "Kartas";
            this.kartasDataGridViewTextBoxColumn.Name = "kartasDataGridViewTextBoxColumn";
            this.kartasDataGridViewTextBoxColumn.ReadOnly = true;
            this.kartasDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipKartesDataGridViewTextBoxColumn
            // 
            this.tipKartesDataGridViewTextBoxColumn.DataPropertyName = "TipKartes";
            this.tipKartesDataGridViewTextBoxColumn.HeaderText = "TipKartes";
            this.tipKartesDataGridViewTextBoxColumn.Name = "tipKartesDataGridViewTextBoxColumn";
            this.tipKartesDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipKartesDataGridViewTextBoxColumn.Visible = false;
            // 
            // cjenikDogadajaBindingSource
            // 
            this.cjenikDogadajaBindingSource.DataSource = typeof(ProdajaKarata.CjenikDogadaja);
            // 
            // FrmCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 293);
            this.Controls.Add(this.btnPregledaj);
            this.Controls.Add(this.dgvPopisCjenika);
            this.Controls.Add(this.btnObrisiCjenik);
            this.Controls.Add(this.btnDodajCjenik);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblCjenikKarata);
            this.Name = "FrmCjenik";
            this.Text = "Cjenici";
            this.Load += new System.EventHandler(this.FrmCjenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisCjenika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cjenikDogadajaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPregledaj;
        private System.Windows.Forms.DataGridView dgvPopisCjenika;
        private System.Windows.Forms.Button btnObrisiCjenik;
        private System.Windows.Forms.Button btnDodajCjenik;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label lblCjenikKarata;
        private System.Windows.Forms.BindingSource cjenikDogadajaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijediOdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijediDoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kartasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipKartesDataGridViewTextBoxColumn;
    }
}

