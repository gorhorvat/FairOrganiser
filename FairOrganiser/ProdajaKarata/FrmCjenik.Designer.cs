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
            this.lblCjenikKarata = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnDodajCjenik = new System.Windows.Forms.Button();
            this.btnObrisiCjenik = new System.Windows.Forms.Button();
            this.dgvPopisCjenika = new System.Windows.Forms.DataGridView();
            this.btnPregledaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisCjenika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCjenikKarata
            // 
            this.lblCjenikKarata.AutoSize = true;
            this.lblCjenikKarata.Location = new System.Drawing.Point(29, 36);
            this.lblCjenikKarata.Name = "lblCjenikKarata";
            this.lblCjenikKarata.Size = new System.Drawing.Size(69, 13);
            this.lblCjenikKarata.TabIndex = 0;
            this.lblCjenikKarata.Text = "Cjenik karata";
            // 
            // dtpOd
            // 
            this.dtpOd.CustomFormat = "";
            this.dtpOd.Location = new System.Drawing.Point(31, 12);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(142, 20);
            this.dtpOd.TabIndex = 1;
            // 
            // dtpDo
            // 
            this.dtpDo.CustomFormat = "";
            this.dtpDo.Location = new System.Drawing.Point(179, 12);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(142, 20);
            this.dtpDo.TabIndex = 2;
            // 
            // btnDodajCjenik
            // 
            this.btnDodajCjenik.Location = new System.Drawing.Point(32, 248);
            this.btnDodajCjenik.Name = "btnDodajCjenik";
            this.btnDodajCjenik.Size = new System.Drawing.Size(75, 23);
            this.btnDodajCjenik.TabIndex = 4;
            this.btnDodajCjenik.Text = "Dodaj cjenik";
            this.btnDodajCjenik.UseVisualStyleBackColor = true;
            this.btnDodajCjenik.Click += new System.EventHandler(this.btnDodajCjenik_Click);
            // 
            // btnObrisiCjenik
            // 
            this.btnObrisiCjenik.Location = new System.Drawing.Point(113, 248);
            this.btnObrisiCjenik.Name = "btnObrisiCjenik";
            this.btnObrisiCjenik.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiCjenik.TabIndex = 5;
            this.btnObrisiCjenik.Text = "Obriši cjenik";
            this.btnObrisiCjenik.UseVisualStyleBackColor = true;
            this.btnObrisiCjenik.Click += new System.EventHandler(this.btnObrisiCjenik_Click);
            // 
            // dgvPopisCjenika
            // 
            this.dgvPopisCjenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisCjenika.ColumnHeadersVisible = false;
            this.dgvPopisCjenika.Location = new System.Drawing.Point(32, 52);
            this.dgvPopisCjenika.Name = "dgvPopisCjenika";
            this.dgvPopisCjenika.ReadOnly = true;
            this.dgvPopisCjenika.RowHeadersVisible = false;
            this.dgvPopisCjenika.Size = new System.Drawing.Size(260, 190);
            this.dgvPopisCjenika.TabIndex = 6;
            // 
            // btnPregledaj
            // 
            this.btnPregledaj.Location = new System.Drawing.Point(194, 248);
            this.btnPregledaj.Name = "btnPregledaj";
            this.btnPregledaj.Size = new System.Drawing.Size(98, 23);
            this.btnPregledaj.TabIndex = 11;
            this.btnPregledaj.Text = "Pregledaj cjenik";
            this.btnPregledaj.UseVisualStyleBackColor = true;
            this.btnPregledaj.Click += new System.EventHandler(this.btnPregledaj_Click);
            // 
            // FrmCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 280);
            this.Controls.Add(this.btnPregledaj);
            this.Controls.Add(this.dgvPopisCjenika);
            this.Controls.Add(this.btnObrisiCjenik);
            this.Controls.Add(this.btnDodajCjenik);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblCjenikKarata);
            this.Name = "FrmCjenik";
            this.Text = "Cjenik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisCjenika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCjenikKarata;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnDodajCjenik;
        private System.Windows.Forms.Button btnObrisiCjenik;
        private System.Windows.Forms.DataGridView dgvPopisCjenika;
        private System.Windows.Forms.Button btnPregledaj;
    }
}