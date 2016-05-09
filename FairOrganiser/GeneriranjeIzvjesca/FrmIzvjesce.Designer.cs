namespace GeneriranjeIzvjesca
{
    partial class FrmIzvjesce
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
            this.txtNazivIzvjesca = new System.Windows.Forms.TextBox();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.btnIspisiIzvjestaj = new System.Windows.Forms.Button();
            this.dgvSadrzaj = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSadrzaj)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNazivIzvjesca
            // 
            this.txtNazivIzvjesca.Location = new System.Drawing.Point(12, 12);
            this.txtNazivIzvjesca.Name = "txtNazivIzvjesca";
            this.txtNazivIzvjesca.ReadOnly = true;
            this.txtNazivIzvjesca.Size = new System.Drawing.Size(406, 20);
            this.txtNazivIzvjesca.TabIndex = 0;
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(12, 38);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(200, 20);
            this.dtpOd.TabIndex = 2;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(218, 38);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(200, 20);
            this.dtpDo.TabIndex = 3;
            // 
            // btnIspisiIzvjestaj
            // 
            this.btnIspisiIzvjestaj.Location = new System.Drawing.Point(496, 412);
            this.btnIspisiIzvjestaj.Name = "btnIspisiIzvjestaj";
            this.btnIspisiIzvjestaj.Size = new System.Drawing.Size(75, 23);
            this.btnIspisiIzvjestaj.TabIndex = 4;
            this.btnIspisiIzvjestaj.Text = "Ispis";
            this.btnIspisiIzvjestaj.UseVisualStyleBackColor = true;
            this.btnIspisiIzvjestaj.Click += new System.EventHandler(this.btnIspisiIzvjestaj_Click);
            // 
            // dgvSadrzaj
            // 
            this.dgvSadrzaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSadrzaj.Location = new System.Drawing.Point(12, 64);
            this.dgvSadrzaj.Name = "dgvSadrzaj";
            this.dgvSadrzaj.Size = new System.Drawing.Size(557, 342);
            this.dgvSadrzaj.TabIndex = 5;
            // 
            // FrmIzvjesce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 444);
            this.Controls.Add(this.dgvSadrzaj);
            this.Controls.Add(this.btnIspisiIzvjestaj);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.txtNazivIzvjesca);
            this.Name = "FrmIzvjesce";
            this.Text = "Izvjesce";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSadrzaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNazivIzvjesca;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Button btnIspisiIzvjestaj;
        private System.Windows.Forms.DataGridView dgvSadrzaj;
    }
}