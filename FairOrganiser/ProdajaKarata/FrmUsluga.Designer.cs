namespace ProdajaKarata
{
    partial class FrmUsluga
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
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaUslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnObrisiUslugu = new System.Windows.Forms.Button();
            this.btnDodajUslugu = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AllowUserToDeleteRows = false;
            this.dgvUsluge.AutoGenerateColumns = false;
            this.dgvUsluge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.cijenaUslugeDataGridViewTextBoxColumn,
            this.racunsDataGridViewTextBoxColumn});
            this.dgvUsluge.DataSource = this.uslugaBindingSource;
            this.dgvUsluge.Location = new System.Drawing.Point(12, 12);
            this.dgvUsluge.MultiSelect = false;
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.RowHeadersVisible = false;
            this.dgvUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsluge.Size = new System.Drawing.Size(701, 284);
            this.dgvUsluge.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "Tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "Napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaUslugeDataGridViewTextBoxColumn
            // 
            this.cijenaUslugeDataGridViewTextBoxColumn.DataPropertyName = "cijenaUsluge";
            this.cijenaUslugeDataGridViewTextBoxColumn.HeaderText = "Cijena usluge";
            this.cijenaUslugeDataGridViewTextBoxColumn.Name = "cijenaUslugeDataGridViewTextBoxColumn";
            this.cijenaUslugeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // racunsDataGridViewTextBoxColumn
            // 
            this.racunsDataGridViewTextBoxColumn.DataPropertyName = "Racuns";
            this.racunsDataGridViewTextBoxColumn.HeaderText = "Racuns";
            this.racunsDataGridViewTextBoxColumn.Name = "racunsDataGridViewTextBoxColumn";
            this.racunsDataGridViewTextBoxColumn.ReadOnly = true;
            this.racunsDataGridViewTextBoxColumn.Visible = false;
            // 
            // uslugaBindingSource
            // 
            this.uslugaBindingSource.DataSource = typeof(ProdajaKarata.Usluga);
            // 
            // btnObrisiUslugu
            // 
            this.btnObrisiUslugu.Location = new System.Drawing.Point(557, 302);
            this.btnObrisiUslugu.Name = "btnObrisiUslugu";
            this.btnObrisiUslugu.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiUslugu.TabIndex = 16;
            this.btnObrisiUslugu.Text = "Obriši uslugu";
            this.btnObrisiUslugu.UseVisualStyleBackColor = true;
            this.btnObrisiUslugu.Click += new System.EventHandler(this.btnObrisiUslugu_Click);
            // 
            // btnDodajUslugu
            // 
            this.btnDodajUslugu.Location = new System.Drawing.Point(467, 302);
            this.btnDodajUslugu.Name = "btnDodajUslugu";
            this.btnDodajUslugu.Size = new System.Drawing.Size(84, 23);
            this.btnDodajUslugu.TabIndex = 15;
            this.btnDodajUslugu.Text = "Dodaj uslugu";
            this.btnDodajUslugu.UseVisualStyleBackColor = true;
            this.btnDodajUslugu.Click += new System.EventHandler(this.btnDodajUslugu_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(638, 302);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 14;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 353);
            this.Controls.Add(this.btnObrisiUslugu);
            this.Controls.Add(this.btnDodajUslugu);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dgvUsluge);
            this.Name = "FrmUsluga";
            this.Text = "Usluge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmUsluga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Button btnObrisiUslugu;
        private System.Windows.Forms.Button btnDodajUslugu;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaUslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunsDataGridViewTextBoxColumn;
    }
}