namespace EvidencijaSudionika
{
    partial class FrmNoviSudionik
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
            this.cmbDogadaj = new System.Windows.Forms.ComboBox();
            this.dogadajBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezimeSudionika = new System.Windows.Forms.TextBox();
            this.txtImeSudionika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajSudionika = new System.Windows.Forms.Button();
            this.txtMedKuca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dogadajBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDogadaj
            // 
            this.cmbDogadaj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDogadaj.DataSource = this.dogadajBindingSource;
            this.cmbDogadaj.DisplayMember = "naziv";
            this.cmbDogadaj.FormattingEnabled = true;
            this.cmbDogadaj.Location = new System.Drawing.Point(108, 160);
            this.cmbDogadaj.Name = "cmbDogadaj";
            this.cmbDogadaj.Size = new System.Drawing.Size(187, 21);
            this.cmbDogadaj.TabIndex = 16;
            this.cmbDogadaj.ValueMember = "naziv";
            // 
            // dogadajBindingSource
            // 
            this.dogadajBindingSource.DataSource = typeof(EvidencijaSudionika.Dogadaj);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Događaj";
            // 
            // txtPrezimeSudionika
            // 
            this.txtPrezimeSudionika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrezimeSudionika.Location = new System.Drawing.Point(108, 48);
            this.txtPrezimeSudionika.Name = "txtPrezimeSudionika";
            this.txtPrezimeSudionika.Size = new System.Drawing.Size(187, 20);
            this.txtPrezimeSudionika.TabIndex = 14;
            // 
            // txtImeSudionika
            // 
            this.txtImeSudionika.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImeSudionika.Location = new System.Drawing.Point(108, 20);
            this.txtImeSudionika.Name = "txtImeSudionika";
            this.txtImeSudionika.Size = new System.Drawing.Size(187, 20);
            this.txtImeSudionika.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime";
            // 
            // btnDodajSudionika
            // 
            this.btnDodajSudionika.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodajSudionika.Location = new System.Drawing.Point(226, 194);
            this.btnDodajSudionika.Name = "btnDodajSudionika";
            this.btnDodajSudionika.Size = new System.Drawing.Size(95, 27);
            this.btnDodajSudionika.TabIndex = 10;
            this.btnDodajSudionika.Text = "Dodaj sudionika";
            this.btnDodajSudionika.UseVisualStyleBackColor = true;
            this.btnDodajSudionika.Click += new System.EventHandler(this.btnDodajSudionika_Click);
            // 
            // txtMedKuca
            // 
            this.txtMedKuca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMedKuca.Location = new System.Drawing.Point(108, 76);
            this.txtMedKuca.Name = "txtMedKuca";
            this.txtMedKuca.Size = new System.Drawing.Size(187, 20);
            this.txtMedKuca.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Medijska kuća";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(108, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtTelefon.Location = new System.Drawing.Point(108, 104);
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(187, 20);
            this.mtxtTelefon.TabIndex = 25;
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.Location = new System.Drawing.Point(125, 194);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(95, 27);
            this.btnOdustani.TabIndex = 26;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // FrmNoviSudionik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 233);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.mtxtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedKuca);
            this.Controls.Add(this.cmbDogadaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezimeSudionika);
            this.Controls.Add(this.txtImeSudionika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajSudionika);
            this.Name = "FrmNoviSudionik";
            this.Text = "Novi sudionik";
            this.Load += new System.EventHandler(this.FrmNoviSudionik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dogadajBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDogadaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezimeSudionika;
        private System.Windows.Forms.TextBox txtImeSudionika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajSudionika;
        private System.Windows.Forms.BindingSource dogadajBindingSource;
        private System.Windows.Forms.TextBox txtMedKuca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.Button btnOdustani;
    }
}