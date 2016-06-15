namespace ProdajaKarata
{
    partial class FrmNovaStavka
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
            this.lblUsluga = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.napomenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaUslugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.racunsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsluga
            // 
            this.lblUsluga.AutoSize = true;
            this.lblUsluga.Location = new System.Drawing.Point(13, 12);
            this.lblUsluga.Name = "lblUsluga";
            this.lblUsluga.Size = new System.Drawing.Size(43, 13);
            this.lblUsluga.TabIndex = 1;
            this.lblUsluga.Text = "Usluga:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(83, 184);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(156, 20);
            this.txtCijena.TabIndex = 2;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(17, 187);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(39, 13);
            this.lblCijena.TabIndex = 3;
            this.lblCijena.Text = "Cijena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Količina:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(83, 236);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 6;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(164, 236);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 7;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.AllowUserToAddRows = false;
            this.dgvUsluge.AutoGenerateColumns = false;
            this.dgvUsluge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.ColumnHeadersVisible = false;
            this.dgvUsluge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.tipDataGridViewTextBoxColumn,
            this.napomenaDataGridViewTextBoxColumn,
            this.cijenaUslugeDataGridViewTextBoxColumn,
            this.racunsDataGridViewTextBoxColumn});
            this.dgvUsluge.DataSource = this.uslugaBindingSource;
            this.dgvUsluge.Location = new System.Drawing.Point(16, 28);
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.ReadOnly = true;
            this.dgvUsluge.RowHeadersVisible = false;
            this.dgvUsluge.Size = new System.Drawing.Size(240, 150);
            this.dgvUsluge.TabIndex = 8;
            this.dgvUsluge.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsluge_CellClick);
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
            // tipDataGridViewTextBoxColumn
            // 
            this.tipDataGridViewTextBoxColumn.DataPropertyName = "tip";
            this.tipDataGridViewTextBoxColumn.HeaderText = "tip";
            this.tipDataGridViewTextBoxColumn.Name = "tipDataGridViewTextBoxColumn";
            this.tipDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipDataGridViewTextBoxColumn.Visible = false;
            // 
            // napomenaDataGridViewTextBoxColumn
            // 
            this.napomenaDataGridViewTextBoxColumn.DataPropertyName = "napomena";
            this.napomenaDataGridViewTextBoxColumn.HeaderText = "napomena";
            this.napomenaDataGridViewTextBoxColumn.Name = "napomenaDataGridViewTextBoxColumn";
            this.napomenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.napomenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cijenaUslugeDataGridViewTextBoxColumn
            // 
            this.cijenaUslugeDataGridViewTextBoxColumn.DataPropertyName = "cijenaUsluge";
            this.cijenaUslugeDataGridViewTextBoxColumn.HeaderText = "cijenaUsluge";
            this.cijenaUslugeDataGridViewTextBoxColumn.Name = "cijenaUslugeDataGridViewTextBoxColumn";
            this.cijenaUslugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaUslugeDataGridViewTextBoxColumn.Visible = false;
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
            // FrmNovaStavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 346);
            this.Controls.Add(this.dgvUsluge);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblUsluga);
            this.Name = "FrmNovaStavka";
            this.Text = "Nova stavka";
            this.Load += new System.EventHandler(this.FrmNovaStavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsluga;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn napomenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaUslugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn racunsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource uslugaBindingSource;
    }
}