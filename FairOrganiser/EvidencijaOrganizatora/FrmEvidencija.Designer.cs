namespace EvidencijaOrganizatora
{
    partial class FrmEvidencija
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
            this.btnObrisiOrganizatora = new System.Windows.Forms.Button();
            this.btnNoviOrganizator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.organizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipOrganizatoraid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipOrganizatoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsedogorgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizatori
            // 
            this.dgvOrganizatori.AllowUserToAddRows = false;
            this.dgvOrganizatori.AllowUserToDeleteRows = false;
            this.dgvOrganizatori.AutoGenerateColumns = false;
            this.dgvOrganizatori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizatori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naziv,
            this.oib,
            this.adresa,
            this.email,
            this.brojTelefona,
            this.TipOrganizatoraid,
            this.tipOrganizatoraDataGridViewTextBoxColumn,
            this.tsedogorgDataGridViewTextBoxColumn});
            this.dgvOrganizatori.DataSource = this.organizatorBindingSource;
            this.dgvOrganizatori.Location = new System.Drawing.Point(17, 34);
            this.dgvOrganizatori.Name = "dgvOrganizatori";
            this.dgvOrganizatori.ReadOnly = true;
            this.dgvOrganizatori.RowHeadersVisible = false;
            this.dgvOrganizatori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrganizatori.Size = new System.Drawing.Size(537, 231);
            this.dgvOrganizatori.TabIndex = 6;
            // 
            // btnObrisiOrganizatora
            // 
            this.btnObrisiOrganizatora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObrisiOrganizatora.Location = new System.Drawing.Point(333, 271);
            this.btnObrisiOrganizatora.Name = "btnObrisiOrganizatora";
            this.btnObrisiOrganizatora.Size = new System.Drawing.Size(106, 27);
            this.btnObrisiOrganizatora.TabIndex = 5;
            this.btnObrisiOrganizatora.Text = "Obriši organizatora";
            this.btnObrisiOrganizatora.UseVisualStyleBackColor = true;
            this.btnObrisiOrganizatora.Click += new System.EventHandler(this.btnObrisiOrganizatora_Click);
            // 
            // btnNoviOrganizator
            // 
            this.btnNoviOrganizator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoviOrganizator.Location = new System.Drawing.Point(443, 271);
            this.btnNoviOrganizator.Name = "btnNoviOrganizator";
            this.btnNoviOrganizator.Size = new System.Drawing.Size(106, 27);
            this.btnNoviOrganizator.TabIndex = 4;
            this.btnNoviOrganizator.Text = "Novi organizator";
            this.btnNoviOrganizator.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Popis organizatora";
            // 
            // organizatorBindingSource
            // 
            this.organizatorBindingSource.DataSource = typeof(EvidencijaOrganizatora.Organizator);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // naziv
            // 
            this.naziv.DataPropertyName = "naziv";
            this.naziv.HeaderText = "Naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // oib
            // 
            this.oib.DataPropertyName = "oib";
            this.oib.HeaderText = "OIB";
            this.oib.Name = "oib";
            this.oib.ReadOnly = true;
            // 
            // adresa
            // 
            this.adresa.DataPropertyName = "adresa";
            this.adresa.HeaderText = "Adresa";
            this.adresa.Name = "adresa";
            this.adresa.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // brojTelefona
            // 
            this.brojTelefona.DataPropertyName = "brojTelefona";
            this.brojTelefona.HeaderText = "Telefon";
            this.brojTelefona.Name = "brojTelefona";
            this.brojTelefona.ReadOnly = true;
            // 
            // TipOrganizatoraid
            // 
            this.TipOrganizatoraid.DataPropertyName = "TipOrganizatoraid";
            this.TipOrganizatoraid.HeaderText = "Tip organizatora";
            this.TipOrganizatoraid.Name = "TipOrganizatoraid";
            this.TipOrganizatoraid.ReadOnly = true;
            // 
            // tipOrganizatoraDataGridViewTextBoxColumn
            // 
            this.tipOrganizatoraDataGridViewTextBoxColumn.DataPropertyName = "TipOrganizatora";
            this.tipOrganizatoraDataGridViewTextBoxColumn.HeaderText = "TipOrganizatora";
            this.tipOrganizatoraDataGridViewTextBoxColumn.Name = "tipOrganizatoraDataGridViewTextBoxColumn";
            this.tipOrganizatoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipOrganizatoraDataGridViewTextBoxColumn.Visible = false;
            // 
            // tsedogorgDataGridViewTextBoxColumn
            // 
            this.tsedogorgDataGridViewTextBoxColumn.DataPropertyName = "tse_dog_org";
            this.tsedogorgDataGridViewTextBoxColumn.HeaderText = "tse_dog_org";
            this.tsedogorgDataGridViewTextBoxColumn.Name = "tsedogorgDataGridViewTextBoxColumn";
            this.tsedogorgDataGridViewTextBoxColumn.ReadOnly = true;
            this.tsedogorgDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmEvidencija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrganizatori);
            this.Controls.Add(this.btnObrisiOrganizatora);
            this.Controls.Add(this.btnNoviOrganizator);
            this.Name = "FrmEvidencija";
            this.Text = "Organizatori";
            this.Load += new System.EventHandler(this.FrmEvidencija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizatori;
        private System.Windows.Forms.Button btnObrisiOrganizatora;
        private System.Windows.Forms.Button btnNoviOrganizator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource organizatorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn oib;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipOrganizatoraid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipOrganizatoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsedogorgDataGridViewTextBoxColumn;
    }
}

