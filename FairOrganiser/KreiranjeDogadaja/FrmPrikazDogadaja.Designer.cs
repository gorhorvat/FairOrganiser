namespace KreiranjeDogadaja
{
    partial class FrmPrikazDogadaja
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
            this.dgvDogadaj = new System.Windows.Forms.DataGridView();
            this.btnIzmjeniDogadaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProstor = new System.Windows.Forms.DataGridView();
            this.dgvUsluge = new System.Windows.Forms.DataGridView();
            this.btnDodajProstor = new System.Windows.Forms.Button();
            this.btnObrišiProstor = new System.Windows.Forms.Button();
            this.btnDodajUslugu = new System.Windows.Forms.Button();
            this.btnObrisiUslugu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dogadajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDogadaj
            // 
            this.dgvDogadaj.AllowUserToAddRows = false;
            this.dgvDogadaj.AllowUserToDeleteRows = false;
            this.dgvDogadaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDogadaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDogadaj.Location = new System.Drawing.Point(12, 25);
            this.dgvDogadaj.MultiSelect = false;
            this.dgvDogadaj.Name = "dgvDogadaj";
            this.dgvDogadaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDogadaj.Size = new System.Drawing.Size(507, 325);
            this.dgvDogadaj.TabIndex = 0;
            this.dgvDogadaj.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDogadaj_CellContentClick);
            // 
            // btnIzmjeniDogadaj
            // 
            this.btnIzmjeniDogadaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIzmjeniDogadaj.Location = new System.Drawing.Point(12, 356);
            this.btnIzmjeniDogadaj.Name = "btnIzmjeniDogadaj";
            this.btnIzmjeniDogadaj.Size = new System.Drawing.Size(93, 23);
            this.btnIzmjeniDogadaj.TabIndex = 3;
            this.btnIzmjeniDogadaj.Text = "Izmjeni događaj";
            this.btnIzmjeniDogadaj.UseVisualStyleBackColor = true;
            this.btnIzmjeniDogadaj.Click += new System.EventHandler(this.btnIzmjeniDogadaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisi.Location = new System.Drawing.Point(426, 356);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(93, 23);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši događaj";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1173, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usluge";
            // 
            // dgvProstor
            // 
            this.dgvProstor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProstor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProstor.Location = new System.Drawing.Point(611, 25);
            this.dgvProstor.MultiSelect = false;
            this.dgvProstor.Name = "dgvProstor";
            this.dgvProstor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProstor.Size = new System.Drawing.Size(462, 325);
            this.dgvProstor.TabIndex = 8;
            // 
            // dgvUsluge
            // 
            this.dgvUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvUsluge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsluge.Location = new System.Drawing.Point(1176, 25);
            this.dgvUsluge.MultiSelect = false;
            this.dgvUsluge.Name = "dgvUsluge";
            this.dgvUsluge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsluge.Size = new System.Drawing.Size(485, 326);
            this.dgvUsluge.TabIndex = 9;
            // 
            // btnDodajProstor
            // 
            this.btnDodajProstor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajProstor.Location = new System.Drawing.Point(611, 356);
            this.btnDodajProstor.Name = "btnDodajProstor";
            this.btnDodajProstor.Size = new System.Drawing.Size(91, 23);
            this.btnDodajProstor.TabIndex = 10;
            this.btnDodajProstor.Text = "Dodaj";
            this.btnDodajProstor.UseVisualStyleBackColor = true;
            // 
            // btnObrišiProstor
            // 
            this.btnObrišiProstor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrišiProstor.Location = new System.Drawing.Point(991, 356);
            this.btnObrišiProstor.Name = "btnObrišiProstor";
            this.btnObrišiProstor.Size = new System.Drawing.Size(82, 23);
            this.btnObrišiProstor.TabIndex = 11;
            this.btnObrišiProstor.Text = "Obriši";
            this.btnObrišiProstor.UseVisualStyleBackColor = true;
            // 
            // btnDodajUslugu
            // 
            this.btnDodajUslugu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDodajUslugu.Location = new System.Drawing.Point(1176, 357);
            this.btnDodajUslugu.Name = "btnDodajUslugu";
            this.btnDodajUslugu.Size = new System.Drawing.Size(75, 23);
            this.btnDodajUslugu.TabIndex = 12;
            this.btnDodajUslugu.Text = "Dodaj";
            this.btnDodajUslugu.UseVisualStyleBackColor = true;
            // 
            // btnObrisiUslugu
            // 
            this.btnObrisiUslugu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObrisiUslugu.Location = new System.Drawing.Point(1586, 356);
            this.btnObrisiUslugu.Name = "btnObrisiUslugu";
            this.btnObrisiUslugu.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiUslugu.TabIndex = 13;
            this.btnObrisiUslugu.Text = "Obriši";
            this.btnObrisiUslugu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Događaji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(608, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Prostori";
            // 
            // dogadajBindingSource
            // 
            this.dogadajBindingSource.DataSource = typeof(KreiranjeDogadaja.Dogadaj);
            // 
            // FrmPrikazDogadaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObrisiUslugu);
            this.Controls.Add(this.btnDodajUslugu);
            this.Controls.Add(this.btnObrišiProstor);
            this.Controls.Add(this.btnDodajProstor);
            this.Controls.Add(this.dgvUsluge);
            this.Controls.Add(this.dgvProstor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzmjeniDogadaj);
            this.Controls.Add(this.dgvDogadaj);
            this.Name = "FrmPrikazDogadaja";
            this.Text = "FrmPrikazDogadaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDogadaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsluge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDogadaj;
        private System.Windows.Forms.Button btnIzmjeniDogadaj;
        private System.Windows.Forms.Button btnObrisi;
        
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProstor;
        private System.Windows.Forms.DataGridView dgvUsluge;
        private System.Windows.Forms.Button btnDodajProstor;
        private System.Windows.Forms.Button btnObrišiProstor;
        private System.Windows.Forms.Button btnDodajUslugu;
        private System.Windows.Forms.Button btnObrisiUslugu;
        private System.Windows.Forms.BindingSource dogadajBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}