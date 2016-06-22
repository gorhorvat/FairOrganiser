namespace GeneriranjeIzvjesca
{
    partial class FrmIspisIzdanihRacunaOperatera
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.IzvjesceIspisIzdanihRacunaZaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16057_IzvjescaDBDataSet = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSet();
            this.rvPodaci = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblZaposlenik = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.IzvjesceIspisIzdanihRacunaZaposlenikTableAdapter = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSetTableAdapters.IzvjesceIspisIzdanihRacunaZaposlenikTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceIspisIzdanihRacunaZaposlenikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IzvjesceIspisIzdanihRacunaZaposlenikBindingSource
            // 
            this.IzvjesceIspisIzdanihRacunaZaposlenikBindingSource.DataMember = "IzvjesceIspisIzdanihRacunaZaposlenik";
            this.IzvjesceIspisIzdanihRacunaZaposlenikBindingSource.DataSource = this._16057_IzvjescaDBDataSet;
            // 
            // _16057_IzvjescaDBDataSet
            // 
            this._16057_IzvjescaDBDataSet.DataSetName = "_16057_IzvjescaDBDataSet";
            this._16057_IzvjescaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvPodaci
            // 
            this.rvPodaci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "IspisIzdanihRacunaOperatera";
            reportDataSource1.Value = this.IzvjesceIspisIzdanihRacunaZaposlenikBindingSource;
            this.rvPodaci.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPodaci.LocalReport.ReportEmbeddedResource = "GeneriranjeIzvjesca.IzvjesceIspisIzdanihRacunaOperatera.rdlc";
            this.rvPodaci.Location = new System.Drawing.Point(12, 47);
            this.rvPodaci.Name = "rvPodaci";
            this.rvPodaci.Size = new System.Drawing.Size(737, 578);
            this.rvPodaci.TabIndex = 7;
            // 
            // lblZaposlenik
            // 
            this.lblZaposlenik.AutoSize = true;
            this.lblZaposlenik.Location = new System.Drawing.Point(12, 15);
            this.lblZaposlenik.Name = "lblZaposlenik";
            this.lblZaposlenik.Size = new System.Drawing.Size(122, 13);
            this.lblZaposlenik.TabIndex = 9;
            this.lblZaposlenik.Text = "Izvješće za zaposlenika:";
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(140, 12);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(84, 20);
            this.txtZaposlenik.TabIndex = 10;
            // 
            // IzvjesceIspisIzdanihRacunaZaposlenikTableAdapter
            // 
            this.IzvjesceIspisIzdanihRacunaZaposlenikTableAdapter.ClearBeforeFill = true;
            // 
            // FrmIspisIzdanihRacunaOperatera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 637);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.lblZaposlenik);
            this.Controls.Add(this.rvPodaci);
            this.Name = "FrmIspisIzdanihRacunaOperatera";
            this.Text = "Ispis izdanih računa operatera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmIspisIzdanihRacunaOperatera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceIspisIzdanihRacunaZaposlenikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPodaci;
        private System.Windows.Forms.Label lblZaposlenik;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.BindingSource IzvjesceIspisIzdanihRacunaZaposlenikBindingSource;
        private _16057_IzvjescaDBDataSet _16057_IzvjescaDBDataSet;
        private _16057_IzvjescaDBDataSetTableAdapters.IzvjesceIspisIzdanihRacunaZaposlenikTableAdapter IzvjesceIspisIzdanihRacunaZaposlenikTableAdapter;
    }
}