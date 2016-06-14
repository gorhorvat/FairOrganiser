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
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.cmbNazivIzvjesca = new System.Windows.Forms.ComboBox();
            this.dtpPeriodOd = new System.Windows.Forms.DateTimePicker();
            this.dtpPeriodDo = new System.Windows.Forms.DateTimePicker();
            this.btnIspis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Location = new System.Drawing.Point(12, 35);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.Size = new System.Drawing.Size(737, 516);
            this.dgvPodaci.TabIndex = 0;
            // 
            // cmbNazivIzvjesca
            // 
            this.cmbNazivIzvjesca.Location = new System.Drawing.Point(12, 8);
            this.cmbNazivIzvjesca.Name = "cmbNazivIzvjesca";
            this.cmbNazivIzvjesca.Size = new System.Drawing.Size(379, 21);
            this.cmbNazivIzvjesca.TabIndex = 1;
            // 
            // dtpPeriodOd
            // 
            this.dtpPeriodOd.Location = new System.Drawing.Point(397, 9);
            this.dtpPeriodOd.Name = "dtpPeriodOd";
            this.dtpPeriodOd.Size = new System.Drawing.Size(173, 20);
            this.dtpPeriodOd.TabIndex = 2;
            // 
            // dtpPeriodDo
            // 
            this.dtpPeriodDo.Location = new System.Drawing.Point(576, 9);
            this.dtpPeriodDo.Name = "dtpPeriodDo";
            this.dtpPeriodDo.Size = new System.Drawing.Size(173, 20);
            this.dtpPeriodDo.TabIndex = 3;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(639, 557);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(110, 36);
            this.btnIspis.TabIndex = 4;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // FrmIzvjesce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 600);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.dtpPeriodDo);
            this.Controls.Add(this.dtpPeriodOd);
            this.Controls.Add(this.cmbNazivIzvjesca);
            this.Controls.Add(this.dgvPodaci);
            this.Name = "FrmIzvjesce";
            this.Text = "Izvješće";
            this.Load += new System.EventHandler(this.FrmIzvjesce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.ComboBox cmbNazivIzvjesca;
        private System.Windows.Forms.DateTimePicker dtpPeriodOd;
        private System.Windows.Forms.DateTimePicker dtpPeriodDo;
        private System.Windows.Forms.Button btnIspis;
    }
}