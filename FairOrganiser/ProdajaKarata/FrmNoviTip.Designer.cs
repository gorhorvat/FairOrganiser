﻿namespace ProdajaKarata
{
    partial class FrmNoviTip
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
            this.lblIznosPopusta = new System.Windows.Forms.Label();
            this.lvlNazivTipa = new System.Windows.Forms.Label();
            this.txtIznosPopusta = new System.Windows.Forms.TextBox();
            this.txtNazivTipa = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIznosPopusta
            // 
            this.lblIznosPopusta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIznosPopusta.AutoSize = true;
            this.lblIznosPopusta.Location = new System.Drawing.Point(10, 37);
            this.lblIznosPopusta.Name = "lblIznosPopusta";
            this.lblIznosPopusta.Size = new System.Drawing.Size(73, 13);
            this.lblIznosPopusta.TabIndex = 9;
            this.lblIznosPopusta.Text = "Iznos popusta";
            // 
            // lvlNazivTipa
            // 
            this.lvlNazivTipa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlNazivTipa.AutoSize = true;
            this.lvlNazivTipa.Location = new System.Drawing.Point(29, 11);
            this.lvlNazivTipa.Name = "lvlNazivTipa";
            this.lvlNazivTipa.Size = new System.Drawing.Size(54, 13);
            this.lvlNazivTipa.TabIndex = 8;
            this.lvlNazivTipa.Text = "Naziv tipa";
            // 
            // txtIznosPopusta
            // 
            this.txtIznosPopusta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIznosPopusta.Location = new System.Drawing.Point(89, 34);
            this.txtIznosPopusta.Name = "txtIznosPopusta";
            this.txtIznosPopusta.Size = new System.Drawing.Size(202, 20);
            this.txtIznosPopusta.TabIndex = 7;
            // 
            // txtNazivTipa
            // 
            this.txtNazivTipa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivTipa.Location = new System.Drawing.Point(89, 8);
            this.txtNazivTipa.Name = "txtNazivTipa";
            this.txtNazivTipa.Size = new System.Drawing.Size(202, 20);
            this.txtNazivTipa.TabIndex = 6;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi.Location = new System.Drawing.Point(89, 60);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(202, 23);
            this.btnPotvrdi.TabIndex = 5;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // FrmNoviTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 111);
            this.Controls.Add(this.lblIznosPopusta);
            this.Controls.Add(this.lvlNazivTipa);
            this.Controls.Add(this.txtIznosPopusta);
            this.Controls.Add(this.txtNazivTipa);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "FrmNoviTip";
            this.Text = "Novi tip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIznosPopusta;
        private System.Windows.Forms.Label lvlNazivTipa;
        private System.Windows.Forms.TextBox txtIznosPopusta;
        private System.Windows.Forms.TextBox txtNazivTipa;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}