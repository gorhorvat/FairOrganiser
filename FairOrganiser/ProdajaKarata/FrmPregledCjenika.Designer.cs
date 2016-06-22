namespace ProdajaKarata
{
    partial class FrmPregledCjenika
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
            this.btnObrisiTip = new System.Windows.Forms.Button();
            this.btnDodajTip = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.lblCjenik = new System.Windows.Forms.Label();
            this.dgvOdabraniCjenik = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosPopustaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjenikDogadajaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cjenikDogadajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipKarteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniCjenik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipKarteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiTip
            // 
            this.btnObrisiTip.Location = new System.Drawing.Point(280, 231);
            this.btnObrisiTip.Name = "btnObrisiTip";
            this.btnObrisiTip.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiTip.TabIndex = 13;
            this.btnObrisiTip.Text = "Obriši tip";
            this.btnObrisiTip.UseVisualStyleBackColor = true;
            this.btnObrisiTip.Click += new System.EventHandler(this.btnObrisiTip_Click);
            // 
            // btnDodajTip
            // 
            this.btnDodajTip.Location = new System.Drawing.Point(199, 231);
            this.btnDodajTip.Name = "btnDodajTip";
            this.btnDodajTip.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTip.TabIndex = 12;
            this.btnDodajTip.Text = "Dodaj tip";
            this.btnDodajTip.UseVisualStyleBackColor = true;
            this.btnDodajTip.Click += new System.EventHandler(this.btnDodajTip_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(361, 231);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 11;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // txtDo
            // 
            this.txtDo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDo.Location = new System.Drawing.Point(170, 7);
            this.txtDo.Name = "txtDo";
            this.txtDo.ReadOnly = true;
            this.txtDo.Size = new System.Drawing.Size(65, 13);
            this.txtDo.TabIndex = 10;
            // 
            // txtOd
            // 
            this.txtOd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOd.Location = new System.Drawing.Point(74, 7);
            this.txtOd.Name = "txtOd";
            this.txtOd.ReadOnly = true;
            this.txtOd.Size = new System.Drawing.Size(65, 13);
            this.txtOd.TabIndex = 9;
            // 
            // lblCjenik
            // 
            this.lblCjenik.AutoSize = true;
            this.lblCjenik.Location = new System.Drawing.Point(12, 7);
            this.lblCjenik.Name = "lblCjenik";
            this.lblCjenik.Size = new System.Drawing.Size(39, 13);
            this.lblCjenik.TabIndex = 8;
            this.lblCjenik.Text = "Cjenik:";
            // 
            // dgvOdabraniCjenik
            // 
            this.dgvOdabraniCjenik.AllowUserToAddRows = false;
            this.dgvOdabraniCjenik.AllowUserToDeleteRows = false;
            this.dgvOdabraniCjenik.AutoGenerateColumns = false;
            this.dgvOdabraniCjenik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdabraniCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniCjenik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iznosPopustaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cjenikDogadajaidDataGridViewTextBoxColumn,
            this.cjenikDogadajaDataGridViewTextBoxColumn});
            this.dgvOdabraniCjenik.DataSource = this.tipKarteBindingSource;
            this.dgvOdabraniCjenik.Location = new System.Drawing.Point(12, 36);
            this.dgvOdabraniCjenik.MultiSelect = false;
            this.dgvOdabraniCjenik.Name = "dgvOdabraniCjenik";
            this.dgvOdabraniCjenik.RowHeadersVisible = false;
            this.dgvOdabraniCjenik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdabraniCjenik.Size = new System.Drawing.Size(429, 189);
            this.dgvOdabraniCjenik.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iznosPopustaDataGridViewTextBoxColumn
            // 
            this.iznosPopustaDataGridViewTextBoxColumn.DataPropertyName = "iznosPopusta";
            this.iznosPopustaDataGridViewTextBoxColumn.HeaderText = "Iznos popusta (%)";
            this.iznosPopustaDataGridViewTextBoxColumn.Name = "iznosPopustaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // cjenikDogadajaidDataGridViewTextBoxColumn
            // 
            this.cjenikDogadajaidDataGridViewTextBoxColumn.DataPropertyName = "CjenikDogadajaid";
            this.cjenikDogadajaidDataGridViewTextBoxColumn.HeaderText = "CjenikDogadajaid";
            this.cjenikDogadajaidDataGridViewTextBoxColumn.Name = "cjenikDogadajaidDataGridViewTextBoxColumn";
            this.cjenikDogadajaidDataGridViewTextBoxColumn.Visible = false;
            // 
            // cjenikDogadajaDataGridViewTextBoxColumn
            // 
            this.cjenikDogadajaDataGridViewTextBoxColumn.DataPropertyName = "CjenikDogadaja";
            this.cjenikDogadajaDataGridViewTextBoxColumn.HeaderText = "CjenikDogadaja";
            this.cjenikDogadajaDataGridViewTextBoxColumn.Name = "cjenikDogadajaDataGridViewTextBoxColumn";
            this.cjenikDogadajaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipKarteBindingSource
            // 
            this.tipKarteBindingSource.DataSource = typeof(ProdajaKarata.TipKarte);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "do";
            // 
            // FrmPregledCjenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObrisiTip);
            this.Controls.Add(this.btnDodajTip);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.lblCjenik);
            this.Controls.Add(this.dgvOdabraniCjenik);
            this.Name = "FrmPregledCjenika";
            this.Text = "Pregled cjenika";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPregledCjenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniCjenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipKarteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiTip;
        private System.Windows.Forms.Button btnDodajTip;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.Label lblCjenik;
        private System.Windows.Forms.DataGridView dgvOdabraniCjenik;
        private System.Windows.Forms.BindingSource tipKarteBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosPopustaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjenikDogadajaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjenikDogadajaDataGridViewTextBoxColumn;
    }
}