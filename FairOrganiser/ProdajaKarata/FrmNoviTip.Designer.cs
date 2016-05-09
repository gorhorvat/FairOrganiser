namespace ProdajaKarata
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblIznosPopusta = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtIznosPopusta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(120, 67);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 0;
            this.btnDodaj.Text = "Dodaj tip";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 18);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblIznosPopusta
            // 
            this.lblIznosPopusta.AutoSize = true;
            this.lblIznosPopusta.Location = new System.Drawing.Point(12, 44);
            this.lblIznosPopusta.Name = "lblIznosPopusta";
            this.lblIznosPopusta.Size = new System.Drawing.Size(73, 13);
            this.lblIznosPopusta.TabIndex = 2;
            this.lblIznosPopusta.Text = "Iznos popusta";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(95, 15);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtIznosPopusta
            // 
            this.txtIznosPopusta.Location = new System.Drawing.Point(95, 41);
            this.txtIznosPopusta.Name = "txtIznosPopusta";
            this.txtIznosPopusta.Size = new System.Drawing.Size(100, 20);
            this.txtIznosPopusta.TabIndex = 4;
            // 
            // FrmNoviTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 101);
            this.Controls.Add(this.txtIznosPopusta);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblIznosPopusta);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnDodaj);
            this.Name = "FrmNoviTip";
            this.Text = "Dodavanje tipova";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblIznosPopusta;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtIznosPopusta;
    }
}