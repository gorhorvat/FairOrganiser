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
            this.btnPotvrdi = new System.Windows.Forms.Button();
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
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(361, 231);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 11;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(187, 7);
            this.txtDo.Name = "txtDo";
            this.txtDo.ReadOnly = true;
            this.txtDo.Size = new System.Drawing.Size(107, 20);
            this.txtDo.TabIndex = 10;
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(74, 7);
            this.txtOd.Name = "txtOd";
            this.txtOd.ReadOnly = true;
            this.txtOd.Size = new System.Drawing.Size(107, 20);
            this.txtOd.TabIndex = 9;
            // 
            // lblCjenik
            // 
            this.lblCjenik.AutoSize = true;
            this.lblCjenik.Location = new System.Drawing.Point(12, 9);
            this.lblCjenik.Name = "lblCjenik";
            this.lblCjenik.Size = new System.Drawing.Size(39, 13);
            this.lblCjenik.TabIndex = 8;
            this.lblCjenik.Text = "Cjenik:";
            // 
            // dgvOdabraniCjenik
            // 
            this.dgvOdabraniCjenik.AllowUserToAddRows = false;
            this.dgvOdabraniCjenik.AutoGenerateColumns = false;
            this.dgvOdabraniCjenik.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdabraniCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniCjenik.ColumnHeadersVisible = false;
            this.dgvOdabraniCjenik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.iznosPopustaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cjenikDogadajaidDataGridViewTextBoxColumn,
            this.cjenikDogadajaDataGridViewTextBoxColumn});
            this.dgvOdabraniCjenik.DataSource = this.tipKarteBindingSource;
            this.dgvOdabraniCjenik.Location = new System.Drawing.Point(12, 36);
            this.dgvOdabraniCjenik.Name = "dgvOdabraniCjenik";
            this.dgvOdabraniCjenik.RowHeadersVisible = false;
            this.dgvOdabraniCjenik.Size = new System.Drawing.Size(429, 189);
            this.dgvOdabraniCjenik.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // iznosPopustaDataGridViewTextBoxColumn
            // 
            this.iznosPopustaDataGridViewTextBoxColumn.DataPropertyName = "iznosPopusta";
            this.iznosPopustaDataGridViewTextBoxColumn.HeaderText = "iznosPopusta";
            this.iznosPopustaDataGridViewTextBoxColumn.Name = "iznosPopustaDataGridViewTextBoxColumn";
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
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
            // FrmPregledCjenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 261);
            this.Controls.Add(this.btnObrisiTip);
            this.Controls.Add(this.btnDodajTip);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.lblCjenik);
            this.Controls.Add(this.dgvOdabraniCjenik);
            this.Name = "FrmPregledCjenika";
            this.Text = "Pregled cjenika";
            this.Load += new System.EventHandler(this.FrmPregledCjenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniCjenik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipKarteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiTip;
        private System.Windows.Forms.Button btnDodajTip;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.Label lblCjenik;
        private System.Windows.Forms.DataGridView dgvOdabraniCjenik;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosPopustaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjenikDogadajaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cjenikDogadajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipKarteBindingSource;
    }
}