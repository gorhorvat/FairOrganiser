namespace EvidencijaSudionika
{
    partial class FrmIzdanaAkreditacija
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
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtMedijskaKuca = new System.Windows.Forms.TextBox();
            this.txtAkreditacija = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.txtDogadaj = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtImePrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImePrezime.Enabled = false;
            this.txtImePrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImePrezime.Location = new System.Drawing.Point(25, 75);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.ReadOnly = true;
            this.txtImePrezime.Size = new System.Drawing.Size(152, 15);
            this.txtImePrezime.TabIndex = 3;
            // 
            // txtMedijskaKuca
            // 
            this.txtMedijskaKuca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMedijskaKuca.Enabled = false;
            this.txtMedijskaKuca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtMedijskaKuca.Location = new System.Drawing.Point(25, 101);
            this.txtMedijskaKuca.Name = "txtMedijskaKuca";
            this.txtMedijskaKuca.ReadOnly = true;
            this.txtMedijskaKuca.Size = new System.Drawing.Size(152, 15);
            this.txtMedijskaKuca.TabIndex = 4;
            // 
            // txtAkreditacija
            // 
            this.txtAkreditacija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAkreditacija.Enabled = false;
            this.txtAkreditacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAkreditacija.Location = new System.Drawing.Point(25, 163);
            this.txtAkreditacija.Name = "txtAkreditacija";
            this.txtAkreditacija.ReadOnly = true;
            this.txtAkreditacija.Size = new System.Drawing.Size(152, 19);
            this.txtAkreditacija.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EvidencijaSudionika.Properties.Resources.zv_logo_mali_hr;
            this.pictureBox3.Location = new System.Drawing.Point(171, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EvidencijaSudionika.Properties.Resources.logo_holding__1_;
            this.pictureBox2.Location = new System.Drawing.Point(13, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(197, 68);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(108, 114);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRCode.TabIndex = 0;
            this.pbQRCode.TabStop = false;
            // 
            // txtDogadaj
            // 
            this.txtDogadaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDogadaj.Enabled = false;
            this.txtDogadaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDogadaj.Location = new System.Drawing.Point(25, 128);
            this.txtDogadaj.Name = "txtDogadaj";
            this.txtDogadaj.ReadOnly = true;
            this.txtDogadaj.Size = new System.Drawing.Size(152, 15);
            this.txtDogadaj.TabIndex = 6;
            // 
            // FrmIzdanaAkreditacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 201);
            this.Controls.Add(this.txtDogadaj);
            this.Controls.Add(this.txtAkreditacija);
            this.Controls.Add(this.txtMedijskaKuca);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbQRCode);
            this.Name = "FrmIzdanaAkreditacija";
            this.Text = "Izdana akreditacija";
            this.Load += new System.EventHandler(this.FrmIzdanaAkreditacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQRCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtMedijskaKuca;
        private System.Windows.Forms.TextBox txtAkreditacija;
        private System.Windows.Forms.TextBox txtDogadaj;
    }
}