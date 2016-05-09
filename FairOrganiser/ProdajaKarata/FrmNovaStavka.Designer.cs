namespace ProdajaKarata
{
    partial class FrmNovaStavka
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
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblTipUsluge = new System.Windows.Forms.Label();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.cmbTipUsluge = new System.Windows.Forms.ComboBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(179, 223);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 0;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 13);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblTipUsluge
            // 
            this.lblTipUsluge.AutoSize = true;
            this.lblTipUsluge.Location = new System.Drawing.Point(12, 44);
            this.lblTipUsluge.Name = "lblTipUsluge";
            this.lblTipUsluge.Size = new System.Drawing.Size(56, 13);
            this.lblTipUsluge.TabIndex = 2;
            this.lblTipUsluge.Text = "Tip usluge";
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(12, 107);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(59, 13);
            this.lblNapomena.TabIndex = 3;
            this.lblNapomena.Text = "Napomena";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(85, 10);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(169, 20);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(85, 104);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(169, 113);
            this.txtNapomena.TabIndex = 5;
            // 
            // cmbTipUsluge
            // 
            this.cmbTipUsluge.FormattingEnabled = true;
            this.cmbTipUsluge.Location = new System.Drawing.Point(85, 41);
            this.cmbTipUsluge.Name = "cmbTipUsluge";
            this.cmbTipUsluge.Size = new System.Drawing.Size(169, 21);
            this.cmbTipUsluge.TabIndex = 6;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(12, 76);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(36, 13);
            this.lblCijena.TabIndex = 7;
            this.lblCijena.Text = "Cijena";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(85, 73);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(169, 20);
            this.txtCijena.TabIndex = 8;
            // 
            // FrmNovaStavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 254);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.cmbTipUsluge);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.lblTipUsluge);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "FrmNovaStavka";
            this.Text = "Nova stavka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblTipUsluge;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.ComboBox cmbTipUsluge;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijena;
    }
}