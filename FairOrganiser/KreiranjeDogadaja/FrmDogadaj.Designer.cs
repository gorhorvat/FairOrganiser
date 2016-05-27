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
            this.btnDodajDogadaj = new System.Windows.Forms.Button();
            this.dtpZavrsetak = new System.Windows.Forms.DateTimePicker();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProstori = new System.Windows.Forms.DataGridView();
            this.dgvOrganizatori = new System.Windows.Forms.DataGridView();
            this.txtCijenaKarte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajDogadaj
            // 
            this.btnDodajDogadaj.Location = new System.Drawing.Point(89, 406);
            this.btnDodajDogadaj.Name = "btnDodajDogadaj";
            this.btnDodajDogadaj.Size = new System.Drawing.Size(120, 23);
            this.btnDodajDogadaj.TabIndex = 4;
            this.btnDodajDogadaj.Text = "Dodaj događaj";
            this.btnDodajDogadaj.UseVisualStyleBackColor = true;
            this.btnDodajDogadaj.Click += new System.EventHandler(this.btnDodajDogadaj_Click);
            // 
            // dtpZavrsetak
            // 
            this.dtpZavrsetak.Location = new System.Drawing.Point(412, 48);
            this.dtpZavrsetak.Name = "dtpZavrsetak";
            this.dtpZavrsetak.Size = new System.Drawing.Size(200, 20);
            this.dtpZavrsetak.TabIndex = 6;
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(185, 48);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(200, 20);
            this.dtpPocetak.TabIndex = 7;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(15, 48);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(135, 20);
            this.tbNaziv.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Odaberite prostore";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Odaberite organizatore";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Početak";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Završetak";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generiraj prikaz za događaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvProstori
            // 
            this.dgvProstori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProstori.Location = new System.Drawing.Point(12, 139);
            this.dgvProstori.Name = "dgvProstori";
            this.dgvProstori.Size = new System.Drawing.Size(283, 251);
            this.dgvProstori.TabIndex = 15;
            // 
            // dgvOrganizatori
            // 
            this.dgvOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizatori.Location = new System.Drawing.Point(329, 139);
            this.dgvOrganizatori.Name = "dgvOrganizatori";
            this.dgvOrganizatori.Size = new System.Drawing.Size(283, 251);
            this.dgvOrganizatori.TabIndex = 16;
            // 
            // txtCijenaKarte
            // 
            this.txtCijenaKarte.Location = new System.Drawing.Point(15, 91);
            this.txtCijenaKarte.Name = "txtCijenaKarte";
            this.txtCijenaKarte.Size = new System.Drawing.Size(135, 20);
            this.txtCijenaKarte.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cijena karte";
            // 
            // FrmDogadaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCijenaKarte);
            this.Controls.Add(this.dgvOrganizatori);
            this.Controls.Add(this.dgvProstori);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.dtpZavrsetak);
            this.Controls.Add(this.btnDodajDogadaj);
            this.Name = "FrmDogadaj";
            this.Text = "Kreiranje događaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProstori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDodajDogadaj;
        private System.Windows.Forms.DateTimePicker dtpZavrsetak;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProstori;
        private System.Windows.Forms.DataGridView dgvOrganizatori;
        private System.Windows.Forms.TextBox txtCijenaKarte;
        private System.Windows.Forms.Label label6;
    }
}