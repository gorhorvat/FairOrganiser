namespace KreiranjeDogadaja
{
    partial class FrmDogadaj
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.btnDodajDogadaj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cijena karte";
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.Location = new System.Drawing.Point(32, 64);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.Size = new System.Drawing.Size(135, 20);
            this.txtCijenaKarte.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Završetak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Početak";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(32, 21);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(135, 20);
            this.txtNaziv.TabIndex = 22;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(202, 21);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetak.TabIndex = 21;
            // 
            // dtpZavrsetak
            // 
            this.dtpZavrsetak.Location = new System.Drawing.Point(429, 21);
            this.dtpZavrsetak.Name = "dtpZavrsetak";
            this.dtpZavrsetak.Size = new System.Drawing.Size(200, 20);
            this.dtpZavrsetak.TabIndex = 20;
            // 
            // btnDodajDogadaj
            // 
            this.btnDodajDogadaj.Location = new System.Drawing.Point(259, 379);
            this.btnDodajDogadaj.Name = "btnDodajDogadaj";
            this.btnDodajDogadaj.Size = new System.Drawing.Size(120, 23);
            this.btnDodajDogadaj.TabIndex = 19;
            this.btnDodajDogadaj.Text = "Dodaj događaj";
            this.btnDodajDogadaj.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(631, 266);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Odabir prostora";
            // 
            // FrmDogadaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCijenaKarte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.dtpZavrsetak);
            this.Controls.Add(this.btnDodajDogadaj);
            this.Name = "FrmDogadaj";
            this.Text = "Događaji";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCijenaKarte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpZavrsetak;
        private System.Windows.Forms.Button btnDodajDogadaj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

