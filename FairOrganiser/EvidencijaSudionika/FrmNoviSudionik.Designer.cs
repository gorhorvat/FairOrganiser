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
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAkreditacija = new System.Windows.Forms.ComboBox();
            this.cmbDogadaj = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezimeSudionika = new System.Windows.Forms.TextBox();
            this.txtImeSudionika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajSudionika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Akreditacija";
            // 
            // cmbAkreditacija
            // 
            this.cmbAkreditacija.FormattingEnabled = true;
            this.cmbAkreditacija.Location = new System.Drawing.Point(108, 122);
            this.cmbAkreditacija.Name = "cmbAkreditacija";
            this.cmbAkreditacija.Size = new System.Drawing.Size(168, 21);
            this.cmbAkreditacija.TabIndex = 17;
            // 
            // cmbDogadaj
            // 
            this.cmbDogadaj.FormattingEnabled = true;
            this.cmbDogadaj.Location = new System.Drawing.Point(108, 86);
            this.cmbDogadaj.Name = "cmbDogadaj";
            this.cmbDogadaj.Size = new System.Drawing.Size(168, 21);
            this.cmbDogadaj.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Događaj";
            // 
            // txtPrezimeSudionika
            // 
            this.txtPrezimeSudionika.Location = new System.Drawing.Point(108, 52);
            this.txtPrezimeSudionika.Name = "txtPrezimeSudionika";
            this.txtPrezimeSudionika.Size = new System.Drawing.Size(168, 20);
            this.txtPrezimeSudionika.TabIndex = 14;
            // 
            // txtImeSudionika
            // 
            this.txtImeSudionika.Location = new System.Drawing.Point(108, 17);
            this.txtImeSudionika.Name = "txtImeSudionika";
            this.txtImeSudionika.Size = new System.Drawing.Size(168, 20);
            this.txtImeSudionika.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ime";
            // 
            // btnDodajSudionika
            // 
            this.btnDodajSudionika.Location = new System.Drawing.Point(204, 149);
            this.btnDodajSudionika.Name = "btnDodajSudionika";
            this.btnDodajSudionika.Size = new System.Drawing.Size(72, 42);
            this.btnDodajSudionika.TabIndex = 10;
            this.btnDodajSudionika.Text = "Dodaj sudionika";
            this.btnDodajSudionika.UseVisualStyleBackColor = true;
            // 
            // FrmNoviSudionik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 265);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAkreditacija);
            this.Controls.Add(this.cmbDogadaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezimeSudionika);
            this.Controls.Add(this.txtImeSudionika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajSudionika);
            this.Name = "FrmNoviSudionik";
            this.Text = "Novi sudionik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAkreditacija;
        private System.Windows.Forms.ComboBox cmbDogadaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezimeSudionika;
        private System.Windows.Forms.TextBox txtImeSudionika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajSudionika;
    }
}