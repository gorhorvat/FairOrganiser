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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.IzvjesceProdaneUslugeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16057_IzvjescaDBDataSet = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSet();
            this.rvPodaci = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IzvjesceProdaneUslugeTableAdapter = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSetTableAdapters.IzvjesceProdaneUslugeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceProdaneUslugeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IzvjesceProdaneUslugeBindingSource
            // 
            this.IzvjesceProdaneUslugeBindingSource.DataMember = "IzvjesceProdaneUsluge";
            this.IzvjesceProdaneUslugeBindingSource.DataSource = this._16057_IzvjescaDBDataSet;
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
            reportDataSource1.Name = "IzvjesceProdaneUsluge";
            reportDataSource1.Value = this.IzvjesceProdaneUslugeBindingSource;
            this.rvPodaci.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPodaci.LocalReport.ReportEmbeddedResource = "GeneriranjeIzvjesca.IzvjesceProdaneUsluge.rdlc";
            this.rvPodaci.Location = new System.Drawing.Point(12, 10);
            this.rvPodaci.Name = "rvPodaci";
            this.rvPodaci.Size = new System.Drawing.Size(836, 578);
            this.rvPodaci.TabIndex = 7;
            // 
            // IzvjesceProdaneUslugeTableAdapter
            // 
            this.IzvjesceProdaneUslugeTableAdapter.ClearBeforeFill = true;
            // 
            // FrmIzvjesceProdaneUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.rvPodaci);
            this.Name = "FrmIzvjesceProdaneUsluge";
            this.Text = "Izvješće o prodanim uslugama";
            this.Load += new System.EventHandler(this.FrmIzvjesceProdaneUsluge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceProdaneUslugeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPodaci;
        private System.Windows.Forms.BindingSource IzvjesceProdaneUslugeBindingSource;
        private _16057_IzvjescaDBDataSet _16057_IzvjescaDBDataSet;
        private _16057_IzvjescaDBDataSetTableAdapters.IzvjesceProdaneUslugeTableAdapter IzvjesceProdaneUslugeTableAdapter;
    }
}