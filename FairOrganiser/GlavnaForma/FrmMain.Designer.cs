namespace GlavnaForma
{
    partial class FrmMain
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
            this.btnUsluge = new System.Windows.Forms.Button();
            this.btnPopusti = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnDogadaj = new System.Windows.Forms.Button();
            this.btnKarta = new System.Windows.Forms.Button();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnIzvjesce = new System.Windows.Forms.Button();
            this.btnSudionici = new System.Windows.Forms.Button();
            this.btnOrganizatori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUsluge
            // 
            this.btnUsluge.Location = new System.Drawing.Point(179, 245);
            this.btnUsluge.Name = "btnUsluge";
            this.btnUsluge.Size = new System.Drawing.Size(213, 31);
            this.btnUsluge.TabIndex = 18;
            this.btnUsluge.Text = "Usluge";
            this.btnUsluge.UseVisualStyleBackColor = true;
            this.btnUsluge.Click += new System.EventHandler(this.btnUsluge_Click);
            // 
            // btnPopusti
            // 
            this.btnPopusti.Location = new System.Drawing.Point(179, 208);
            this.btnPopusti.Name = "btnPopusti";
            this.btnPopusti.Size = new System.Drawing.Size(213, 31);
            this.btnPopusti.TabIndex = 17;
            this.btnPopusti.Text = "Popusti";
            this.btnPopusti.UseVisualStyleBackColor = true;
            this.btnPopusti.Click += new System.EventHandler(this.btnPopusti_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(179, 319);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(213, 31);
            this.btnOdjava.TabIndex = 16;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnDogadaj
            // 
            this.btnDogadaj.Location = new System.Drawing.Point(179, 282);
            this.btnDogadaj.Name = "btnDogadaj";
            this.btnDogadaj.Size = new System.Drawing.Size(213, 31);
            this.btnDogadaj.TabIndex = 15;
            this.btnDogadaj.Text = "Događaji";
            this.btnDogadaj.UseVisualStyleBackColor = true;
            this.btnDogadaj.Click += new System.EventHandler(this.btnDogadaj_Click);
            // 
            // btnKarta
            // 
            this.btnKarta.Location = new System.Drawing.Point(179, 171);
            this.btnKarta.Name = "btnKarta";
            this.btnKarta.Size = new System.Drawing.Size(213, 31);
            this.btnKarta.TabIndex = 14;
            this.btnKarta.Text = "Karta";
            this.btnKarta.UseVisualStyleBackColor = true;
            this.btnKarta.Click += new System.EventHandler(this.btnKarta_Click);
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(179, 134);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(213, 31);
            this.btnRacun.TabIndex = 13;
            this.btnRacun.Text = "Račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnIzvjesce
            // 
            this.btnIzvjesce.Location = new System.Drawing.Point(179, 97);
            this.btnIzvjesce.Name = "btnIzvjesce";
            this.btnIzvjesce.Size = new System.Drawing.Size(213, 31);
            this.btnIzvjesce.TabIndex = 12;
            this.btnIzvjesce.Text = "Izvješća";
            this.btnIzvjesce.UseVisualStyleBackColor = true;
            this.btnIzvjesce.Click += new System.EventHandler(this.btnIzvjesce_Click);
            // 
            // btnSudionici
            // 
            this.btnSudionici.Location = new System.Drawing.Point(179, 60);
            this.btnSudionici.Name = "btnSudionici";
            this.btnSudionici.Size = new System.Drawing.Size(213, 31);
            this.btnSudionici.TabIndex = 11;
            this.btnSudionici.Text = "Sudionici";
            this.btnSudionici.UseVisualStyleBackColor = true;
            this.btnSudionici.Click += new System.EventHandler(this.btnSudionici_Click);
            // 
            // btnOrganizatori
            // 
            this.btnOrganizatori.Location = new System.Drawing.Point(179, 23);
            this.btnOrganizatori.Name = "btnOrganizatori";
            this.btnOrganizatori.Size = new System.Drawing.Size(213, 31);
            this.btnOrganizatori.TabIndex = 10;
            this.btnOrganizatori.Text = "Organizatori";
            this.btnOrganizatori.UseVisualStyleBackColor = true;
            this.btnOrganizatori.Click += new System.EventHandler(this.btnOrganizatori_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 372);
            this.Controls.Add(this.btnUsluge);
            this.Controls.Add(this.btnPopusti);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDogadaj);
            this.Controls.Add(this.btnKarta);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.btnIzvjesce);
            this.Controls.Add(this.btnSudionici);
            this.Controls.Add(this.btnOrganizatori);
            this.Name = "FrmMain";
            this.Text = "Glavni izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUsluge;
        private System.Windows.Forms.Button btnPopusti;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnDogadaj;
        private System.Windows.Forms.Button btnKarta;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnIzvjesce;
        private System.Windows.Forms.Button btnSudionici;
        private System.Windows.Forms.Button btnOrganizatori;
    }
}

