namespace GeneriranjeIzvjesca
{
    partial class FrmIzvjesceBrojPosjetitelja
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
            this.IzvjesceBrojPosjetiteljaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16057_IzvjescaDBDataSet = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSet();
            this.rvPodaci = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IzvjesceBrojPosjetiteljaTableAdapter = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSetTableAdapters.IzvjesceBrojPosjetiteljaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceBrojPosjetiteljaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IzvjesceBrojPosjetiteljaBindingSource
            // 
            this.IzvjesceBrojPosjetiteljaBindingSource.DataMember = "IzvjesceBrojPosjetitelja";
            this.IzvjesceBrojPosjetiteljaBindingSource.DataSource = this._16057_IzvjescaDBDataSet;
            // 
            // _16057_IzvjescaDBDataSet
            // 
            this._16057_IzvjescaDBDataSet.DataSetName = "_16057_IzvjescaDBDataSet";
            this._16057_IzvjescaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvPodaci
            // 
            reportDataSource1.Name = "BrojPosjetitelja";
            reportDataSource1.Value = this.IzvjesceBrojPosjetiteljaBindingSource;
            this.rvPodaci.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPodaci.LocalReport.ReportEmbeddedResource = "GeneriranjeIzvjesca.IzvjesceBrojPosjetitelja.rdlc";
            this.rvPodaci.Location = new System.Drawing.Point(12, 12);
            this.rvPodaci.Name = "rvPodaci";
            this.rvPodaci.Size = new System.Drawing.Size(737, 576);
            this.rvPodaci.TabIndex = 5;
            // 
            // IzvjesceBrojPosjetiteljaTableAdapter
            // 
            this.IzvjesceBrojPosjetiteljaTableAdapter.ClearBeforeFill = true;
            // 
            // FrmIzvjesceBrojPosjetitelja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 600);
            this.Controls.Add(this.rvPodaci);
            this.Name = "FrmIzvjesceBrojPosjetitelja";
            this.Text = "Izvješće o broju posjetitelja";
            this.Load += new System.EventHandler(this.FrmIzvjesce_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceBrojPosjetiteljaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rvPodaci;
        private System.Windows.Forms.BindingSource IzvjesceBrojPosjetiteljaBindingSource;
        private _16057_IzvjescaDBDataSet _16057_IzvjescaDBDataSet;
        private _16057_IzvjescaDBDataSetTableAdapters.IzvjesceBrojPosjetiteljaTableAdapter IzvjesceBrojPosjetiteljaTableAdapter;
    }
}