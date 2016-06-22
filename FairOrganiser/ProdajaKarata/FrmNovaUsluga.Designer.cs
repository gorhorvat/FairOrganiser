namespace ProdajaKarata
{
    partial class FrmNovaUsluga
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
            this.lblTipUsluge = new System.Windows.Forms.Label();
            this.lvlNazivUsluge = new System.Windows.Forms.Label();
            this.txtTipUsluge = new System.Windows.Forms.TextBox();
            this.txtNazivUsluge = new System.Windows.Forms.TextBox();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.lblNapomena = new System.Windows.Forms.Label();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.lblCijena = new System.Windows.Forms.Label();
            this.txtCijenaUsluge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTipUsluge
            // 
            this.lblTipUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipUsluge.AutoSize = true;
            this.lblTipUsluge.Location = new System.Drawing.Point(14, 38);
            this.lblTipUsluge.Name = "lblTipUsluge";
            this.lblTipUsluge.Size = new System.Drawing.Size(56, 13);
            this.lblTipUsluge.TabIndex = 14;
            this.lblTipUsluge.Text = "Tip usluge";
            // 
            // lvlNazivUsluge
            // 
            this.lvlNazivUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlNazivUsluge.AutoSize = true;
            this.lvlNazivUsluge.Location = new System.Drawing.Point(14, 12);
            this.lvlNazivUsluge.Name = "lvlNazivUsluge";
            this.lvlNazivUsluge.Size = new System.Drawing.Size(68, 13);
            this.lvlNazivUsluge.TabIndex = 13;
            this.lvlNazivUsluge.Text = "Naziv usluge";
            // 
            // txtTipUsluge
            // 
            this.txtTipUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTipUsluge.Location = new System.Drawing.Point(116, 38);
            this.txtTipUsluge.Name = "txtTipUsluge";
            this.txtTipUsluge.Size = new System.Drawing.Size(426, 20);
            this.txtTipUsluge.TabIndex = 12;
            // 
            // txtNazivUsluge
            // 
            this.txtNazivUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNazivUsluge.Location = new System.Drawing.Point(116, 12);
            this.txtNazivUsluge.Name = "txtNazivUsluge";
            this.txtNazivUsluge.Size = new System.Drawing.Size(426, 20);
            this.txtNazivUsluge.TabIndex = 11;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPotvrdi.Location = new System.Drawing.Point(335, 151);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(207, 37);
            this.btnPotvrdi.TabIndex = 10;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // lblNapomena
            // 
            this.lblNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(14, 64);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(59, 13);
            this.lblNapomena.TabIndex = 16;
            this.lblNapomena.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNapomena.Location = new System.Drawing.Point(116, 64);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(426, 55);
            this.txtNapomena.TabIndex = 15;
            // 
            // lblCijena
            // 
            this.lblCijena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(12, 125);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(70, 13);
            this.lblCijena.TabIndex = 18;
            this.lblCijena.Text = "Cijena usluge";
            // 
            // txtCijenaUsluge
            // 
            this.txtCijenaUsluge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCijenaUsluge.Location = new System.Drawing.Point(114, 125);
            this.txtCijenaUsluge.Name = "txtCijenaUsluge";
            this.txtCijenaUsluge.Size = new System.Drawing.Size(426, 20);
            this.txtCijenaUsluge.TabIndex = 17;
            // 
            // FrmNovaUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 198);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.txtCijenaUsluge);
            this.Controls.Add(this.lblNapomena);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.lblTipUsluge);
            this.Controls.Add(this.lvlNazivUsluge);
            this.Controls.Add(this.txtTipUsluge);
            this.Controls.Add(this.txtNazivUsluge);
            this.Controls.Add(this.btnPotvrdi);
            this.Name = "FrmNovaUsluga";
            this.Text = "Nova usluga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipUsluge;
        private System.Windows.Forms.Label lvlNazivUsluge;
        private System.Windows.Forms.TextBox txtTipUsluge;
        private System.Windows.Forms.TextBox txtNazivUsluge;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Label lblNapomena;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox txtCijenaUsluge;
    }
}