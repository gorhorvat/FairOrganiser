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
            this.btnDodajNovi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvTipoviKarata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviKarata)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCjenikKarata
            // 
            this.lblCjenikKarata.AutoSize = true;
            this.lblCjenikKarata.Location = new System.Drawing.Point(29, 28);
            this.lblCjenikKarata.Name = "lblCjenikKarata";
            this.lblCjenikKarata.Size = new System.Drawing.Size(69, 13);
            this.lblCjenikKarata.TabIndex = 0;
            this.lblCjenikKarata.Text = "Cjenik karata";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(129, 26);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(142, 20);
            this.dtpOd.TabIndex = 1;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(277, 26);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(142, 20);
            this.dtpDo.TabIndex = 2;
            // 
            // btnDodajNovi
            // 
            this.btnDodajNovi.Location = new System.Drawing.Point(263, 248);
            this.btnDodajNovi.Name = "btnDodajNovi";
            this.btnDodajNovi.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNovi.TabIndex = 4;
            this.btnDodajNovi.Text = "Dodaj novi";
            this.btnDodajNovi.UseVisualStyleBackColor = true;
            this.btnDodajNovi.Click += new System.EventHandler(this.btnDodajNovi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(344, 248);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // dgvTipoviKarata
            // 
            this.dgvTipoviKarata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoviKarata.Location = new System.Drawing.Point(32, 52);
            this.dgvTipoviKarata.Name = "dgvTipoviKarata";
            this.dgvTipoviKarata.Size = new System.Drawing.Size(387, 190);
            this.dgvTipoviKarata.TabIndex = 6;
            // 
            // FrmCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 280);
            this.Controls.Add(this.dgvTipoviKarata);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodajNovi);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblCjenikKarata);
            this.Name = "FrmCjenik";
            this.Text = "Cjenik";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoviKarata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCjenikKarata;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnDodajNovi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvTipoviKarata;
    }
}