namespace KreiranjeDogadaja
{
    partial class FrmOrganizatorDogadaj
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
            this.dgvOrganizatori = new System.Windows.Forms.DataGridView();
            this.btnDodajOrganizatore = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipOrganizatoraidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipOrganizatoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsedogorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.organizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizatori
            // 
            this.dgvOrganizatori.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrganizatori.AutoGenerateColumns = false;
            this.dgvOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizatori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.oibDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.brojTelefonaDataGridViewTextBoxColumn,
            this.tipOrganizatoraidDataGridViewTextBoxColumn,
            this.tipOrganizatoraDataGridViewTextBoxColumn,
            this.tsedogorgDataGridViewTextBoxColumn});
            this.dgvOrganizatori.DataSource = this.organizatorBindingSource;
            this.dgvOrganizatori.Location = new System.Drawing.Point(12, 12);
            this.dgvOrganizatori.Name = "dgvOrganizatori";
            this.dgvOrganizatori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizatori.Size = new System.Drawing.Size(347, 362);
            this.dgvOrganizatori.TabIndex = 0;
            // 
            // btnDodajOrganizatore
            // 
            this.btnDodajOrganizatore.Location = new System.Drawing.Point(122, 380);
            this.btnDodajOrganizatore.Name = "btnDodajOrganizatore";
            this.btnDodajOrganizatore.Size = new System.Drawing.Size(119, 23);
            this.btnDodajOrganizatore.TabIndex = 1;
            this.btnDodajOrganizatore.Text = "Dodaj organizatore";
            this.btnDodajOrganizatore.UseVisualStyleBackColor = true;
            this.btnDodajOrganizatore.Click += new System.EventHandler(this.btnDodajOrganizatore_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            // 
            // oibDataGridViewTextBoxColumn
            // 
            this.oibDataGridViewTextBoxColumn.DataPropertyName = "oib";
            this.oibDataGridViewTextBoxColumn.HeaderText = "oib";
            this.oibDataGridViewTextBoxColumn.Name = "oibDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // brojTelefonaDataGridViewTextBoxColumn
            // 
            this.brojTelefonaDataGridViewTextBoxColumn.DataPropertyName = "brojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.HeaderText = "brojTelefona";
            this.brojTelefonaDataGridViewTextBoxColumn.Name = "brojTelefonaDataGridViewTextBoxColumn";
            this.brojTelefonaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipOrganizatoraidDataGridViewTextBoxColumn
            // 
            this.tipOrganizatoraidDataGridViewTextBoxColumn.DataPropertyName = "TipOrganizatoraid";
            this.tipOrganizatoraidDataGridViewTextBoxColumn.HeaderText = "TipOrganizatoraid";
            this.tipOrganizatoraidDataGridViewTextBoxColumn.Name = "tipOrganizatoraidDataGridViewTextBoxColumn";
            this.tipOrganizatoraidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipOrganizatoraDataGridViewTextBoxColumn
            // 
            this.tipOrganizatoraDataGridViewTextBoxColumn.DataPropertyName = "TipOrganizatora";
            this.tipOrganizatoraDataGridViewTextBoxColumn.HeaderText = "TipOrganizatora";
            this.tipOrganizatoraDataGridViewTextBoxColumn.Name = "tipOrganizatoraDataGridViewTextBoxColumn";
            this.tipOrganizatoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // tsedogorgDataGridViewTextBoxColumn
            // 
            this.tsedogorgDataGridViewTextBoxColumn.DataPropertyName = "tse_dog_org";
            this.tsedogorgDataGridViewTextBoxColumn.HeaderText = "tse_dog_org";
            this.tsedogorgDataGridViewTextBoxColumn.Name = "tsedogorgDataGridViewTextBoxColumn";
            this.tsedogorgDataGridViewTextBoxColumn.Visible = false;
            // 
            // organizatorBindingSource
            // 
            this.organizatorBindingSource.DataSource = typeof(KreiranjeDogadaja.Organizator);
            // 
            // FrmOrganizatorDogadaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 415);
            this.Controls.Add(this.btnDodajOrganizatore);
            this.Controls.Add(this.dgvOrganizatori);
            this.Name = "FrmOrganizatorDogadaj";
            this.Text = "OrganizatorDogadaj";
            this.Load += new System.EventHandler(this.FrmOrganizatorDogadaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizatorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizatori;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipOrganizatoraidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipOrganizatoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsedogorgDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource organizatorBindingSource;
        private System.Windows.Forms.Button btnDodajOrganizatore;
    }
}