﻿namespace GlavnaForma
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
            this.btnOrganizatori = new System.Windows.Forms.Button();
            this.btnSudionici = new System.Windows.Forms.Button();
            this.btnCjenik = new System.Windows.Forms.Button();
            this.btnIzvjesce = new System.Windows.Forms.Button();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnKarta = new System.Windows.Forms.Button();
            this.btnDogadaj = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrganizatori
            // 
            this.btnOrganizatori.Location = new System.Drawing.Point(158, 20);
            this.btnOrganizatori.Name = "btnOrganizatori";
            this.btnOrganizatori.Size = new System.Drawing.Size(213, 31);
            this.btnOrganizatori.TabIndex = 0;
            this.btnOrganizatori.Text = "Organizatori";
            this.btnOrganizatori.UseVisualStyleBackColor = true;
            this.btnOrganizatori.Click += new System.EventHandler(this.btnOrganizatori_Click);
            // 
            // btnSudionici
            // 
            this.btnSudionici.Location = new System.Drawing.Point(158, 57);
            this.btnSudionici.Name = "btnSudionici";
            this.btnSudionici.Size = new System.Drawing.Size(213, 31);
            this.btnSudionici.TabIndex = 1;
            this.btnSudionici.Text = "Sudionici";
            this.btnSudionici.UseVisualStyleBackColor = true;
            this.btnSudionici.Click += new System.EventHandler(this.btnSudionici_Click);
            // 
            // btnCjenik
            // 
            this.btnCjenik.Location = new System.Drawing.Point(158, 94);
            this.btnCjenik.Name = "btnCjenik";
            this.btnCjenik.Size = new System.Drawing.Size(213, 31);
            this.btnCjenik.TabIndex = 2;
            this.btnCjenik.Text = "Cjenik";
            this.btnCjenik.UseVisualStyleBackColor = true;
            this.btnCjenik.Click += new System.EventHandler(this.btnCjenik_Click);
            // 
            // btnIzvjesce
            // 
            this.btnIzvjesce.Location = new System.Drawing.Point(158, 131);
            this.btnIzvjesce.Name = "btnIzvjesce";
            this.btnIzvjesce.Size = new System.Drawing.Size(213, 31);
            this.btnIzvjesce.TabIndex = 3;
            this.btnIzvjesce.Text = "Izvješće";
            this.btnIzvjesce.UseVisualStyleBackColor = true;
            this.btnIzvjesce.Click += new System.EventHandler(this.btnIzvjesce_Click);
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(158, 168);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(213, 31);
            this.btnRacun.TabIndex = 4;
            this.btnRacun.Text = "Račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnKarta
            // 
            this.btnKarta.Location = new System.Drawing.Point(158, 205);
            this.btnKarta.Name = "btnKarta";
            this.btnKarta.Size = new System.Drawing.Size(213, 31);
            this.btnKarta.TabIndex = 5;
            this.btnKarta.Text = "Karta";
            this.btnKarta.UseVisualStyleBackColor = true;
            this.btnKarta.Click += new System.EventHandler(this.btnKarta_Click);
            // 
            // btnDogadaj
            // 
            this.btnDogadaj.Location = new System.Drawing.Point(158, 242);
            this.btnDogadaj.Name = "btnDogadaj";
            this.btnDogadaj.Size = new System.Drawing.Size(213, 31);
            this.btnDogadaj.TabIndex = 6;
            this.btnDogadaj.Text = "Dogadaj";
            this.btnDogadaj.UseVisualStyleBackColor = true;
            this.btnDogadaj.Click += new System.EventHandler(this.btnDogadaj_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(158, 279);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(213, 31);
            this.btnOdjava.TabIndex = 7;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 329);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnDogadaj);
            this.Controls.Add(this.btnKarta);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.btnIzvjesce);
            this.Controls.Add(this.btnCjenik);
            this.Controls.Add(this.btnSudionici);
            this.Controls.Add(this.btnOrganizatori);
            this.Name = "FrmMain";
            this.Text = "Glavni izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrganizatori;
        private System.Windows.Forms.Button btnSudionici;
        private System.Windows.Forms.Button btnCjenik;
        private System.Windows.Forms.Button btnIzvjesce;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnKarta;
        private System.Windows.Forms.Button btnDogadaj;
        private System.Windows.Forms.Button btnOdjava;
    }
}

