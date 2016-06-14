namespace GeneriranjeIzvjesca
{
    partial class FrmIzvjesceProdaneUsluge
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvPodaci = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIspis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rvPodaci
            // 
            reportDataSource1.Name = "BrojPosjetitelja";
            reportDataSource1.Value = null;
            this.rvPodaci.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPodaci.LocalReport.ReportEmbeddedResource = "GeneriranjeIzvjesca.IzvjesceBrojPosjetitelja.rdlc";
            this.rvPodaci.Location = new System.Drawing.Point(12, 10);
            this.rvPodaci.Name = "rvPodaci";
            this.rvPodaci.Size = new System.Drawing.Size(737, 539);
            this.rvPodaci.TabIndex = 7;
            // 
            // btnIspis
            // 
            this.btnIspis.Location = new System.Drawing.Point(639, 555);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(110, 36);
            this.btnIspis.TabIndex = 6;
            this.btnIspis.Text = "Ispis";
            this.btnIspis.UseVisualStyleBackColor = true;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // FrmIzvjesceProdaneUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 600);
            this.Controls.Add(this.rvPodaci);
            this.Controls.Add(this.btnIspis);
            this.Name = "FrmIzvjesceProdaneUsluge";
            this.Text = "Izvješće o prodanim uslugama";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPodaci;
        private System.Windows.Forms.Button btnIspis;
    }
}