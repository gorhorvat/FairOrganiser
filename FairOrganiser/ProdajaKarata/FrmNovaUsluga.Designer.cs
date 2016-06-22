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
            this.lblTipUsluge.AutoSize = true;
            this.lblTipUsluge.Location = new System.Drawing.Point(19, 43);
            this.lblTipUsluge.Name = "lblTipUsluge";
            this.lblTipUsluge.Size = new System.Drawing.Size(56, 13);
            this.lblTipUsluge.TabIndex = 14;
            this.lblTipUsluge.Text = "Tip usluge";
            // 
            // lvlNazivUsluge
            // 
            this.lvlNazivUsluge.AutoSize = true;
            this.lvlNazivUsluge.Location = new System.Drawing.Point(19, 17);
            this.lvlNazivUsluge.Name = "lvlNazivUsluge";
            this.lvlNazivUsluge.Size = new System.Drawing.Size(68, 13);
            this.lvlNazivUsluge.TabIndex = 13;
            this.lvlNazivUsluge.Text = "Naziv usluge";
            // 
            // txtTipUsluge
            // 
            this.txtTipUsluge.Location = new System.Drawing.Point(103, 40);
            this.txtTipUsluge.Name = "txtTipUsluge";
            this.txtTipUsluge.Size = new System.Drawing.Size(126, 20);
            this.txtTipUsluge.TabIndex = 12;
            // 
            // txtNazivUsluge
            // 
            this.txtNazivUsluge.Location = new System.Drawing.Point(103, 14);
            this.txtNazivUsluge.Name = "txtNazivUsluge";
            this.txtNazivUsluge.Size = new System.Drawing.Size(126, 20);
            this.txtNazivUsluge.TabIndex = 11;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(22, 118);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(207, 37);
            this.btnPotvrdi.TabIndex = 10;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // lblNapomena
            // 
            this.lblNapomena.AutoSize = true;
            this.lblNapomena.Location = new System.Drawing.Point(19, 69);
            this.lblNapomena.Name = "lblNapomena";
            this.lblNapomena.Size = new System.Drawing.Size(59, 13);
            this.lblNapomena.TabIndex = 16;
            this.lblNapomena.Text = "Napomena";
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(103, 66);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(126, 20);
            this.txtNapomena.TabIndex = 15;
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(19, 95);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(70, 13);
            this.lblCijena.TabIndex = 18;
            this.lblCijena.Text = "Cijena usluge";
            // 
            // txtCijenaUsluge
            // 
            this.txtCijenaUsluge.Location = new System.Drawing.Point(103, 92);
            this.txtCijenaUsluge.Name = "txtCijenaUsluge";
            this.txtCijenaUsluge.Size = new System.Drawing.Size(126, 20);
            this.txtCijenaUsluge.TabIndex = 17;
            // 
            // FrmNovaUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 165);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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