namespace GeneriranjeIzvjesca
{
    partial class FrmIzvjesceOrganiziraniDogadaji
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
            this.IzvjesceOrganizatoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._16057_IzvjescaDBDataSet = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSet();
            this.rvPodaci = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnIspis = new System.Windows.Forms.Button();
            this.IzvjesceOrganizatoriTableAdapter = new GeneriranjeIzvjesca._16057_IzvjescaDBDataSetTableAdapters.IzvjesceOrganizatoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceOrganizatoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // IzvjesceOrganizatoriBindingSource
            // 
            this.IzvjesceOrganizatoriBindingSource.DataMember = "IzvjesceOrganizatori";
            this.IzvjesceOrganizatoriBindingSource.DataSource = this._16057_IzvjescaDBDataSet;
            // 
            // _16057_IzvjescaDBDataSet
            // 
            this._16057_IzvjescaDBDataSet.DataSetName = "_16057_IzvjescaDBDataSet";
            this._16057_IzvjescaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvPodaci
            // 
            reportDataSource1.Name = "OrganiziraniDogadaji";
            reportDataSource1.Value = this.IzvjesceOrganizatoriBindingSource;
            this.rvPodaci.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPodaci.LocalReport.ReportEmbeddedResource = "GeneriranjeIzvjesca.IzvjesceOrganiziraniDogadaji.rdlc";
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
            // IzvjesceOrganizatoriTableAdapter
            // 
            this.IzvjesceOrganizatoriTableAdapter.ClearBeforeFill = true;
            // 
            // FrmIzvjesceOrganiziraniDogadaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(761, 600);
            this.Controls.Add(this.rvPodaci);
            this.Controls.Add(this.btnIspis);
            this.Name = "FrmIzvjesceOrganiziraniDogadaji";
            this.Text = "Izvješće o organiziranim događajima";
            this.Load += new System.EventHandler(this.FrmIzvjesceOrganiziraniDogadaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IzvjesceOrganizatoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._16057_IzvjescaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvPodaci;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.BindingSource IzvjesceOrganizatoriBindingSource;
        private _16057_IzvjescaDBDataSet _16057_IzvjescaDBDataSet;
        private _16057_IzvjescaDBDataSetTableAdapters.IzvjesceOrganizatoriTableAdapter IzvjesceOrganizatoriTableAdapter;
    }
}