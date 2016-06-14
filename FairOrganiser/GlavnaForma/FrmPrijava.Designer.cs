namespace GlavnaForma
{
    partial class FrmPrijava
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
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(193, 188);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 23);
            this.btnPrijava.TabIndex = 9;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(146, 130);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(166, 20);
            this.txtLozinka.TabIndex = 8;
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(207, 114);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 7;
            this.lblLozinka.Text = "Lozinka";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(146, 66);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(166, 20);
            this.txtKorisnickoIme.TabIndex = 6;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(190, 50);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnickoIme.TabIndex = 5;
            this.lblKorisnickoIme.Text = "Korisničko ime";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GlavnaForma.Properties.Resources.zv_logo_mali_hr;
            this.pictureBox3.Location = new System.Drawing.Point(313, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::GlavnaForma.Properties.Resources.logo_holding__1_;
            this.pictureBox2.Image = global::GlavnaForma.Properties.Resources.logo_holding__1_;
            this.pictureBox2.Location = new System.Drawing.Point(12, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.lblKorisnickoIme);
            this.Name = "FrmPrijava";
            this.Text = "Prijava";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}