namespace ProdajaKarata
{
    partial class FrmCjenik
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
            this.lblCjenikKarata = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.chkTipKarte1 = new System.Windows.Forms.CheckBox();
            this.btnDodajNovi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.grpTipoviKarata = new System.Windows.Forms.GroupBox();
            this.chkTipKarte2 = new System.Windows.Forms.CheckBox();
            this.chkTipKarte3 = new System.Windows.Forms.CheckBox();
            this.grpTipoviKarata.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCjenikKarata
            // 
            this.lblCjenikKarata.AutoSize = true;
            this.lblCjenikKarata.Location = new System.Drawing.Point(29, 28);
            this.lblCjenikKarata.Name = "lblCjenikKarata";
            this.lblCjenikKarata.Size = new System.Drawing.Size(69, 13);
            this.lblCjenikKarata.TabIndex = 0;
            this.lblCjenikKarata.Text = "Cjenik karata";
            // 
            // dtpOd
            // 
            this.dtpOd.Location = new System.Drawing.Point(129, 26);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(142, 20);
            this.dtpOd.TabIndex = 1;
            // 
            // dtpDo
            // 
            this.dtpDo.Location = new System.Drawing.Point(277, 26);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(142, 20);
            this.dtpDo.TabIndex = 2;
            // 
            // chkTipKarte1
            // 
            this.chkTipKarte1.AutoSize = true;
            this.chkTipKarte1.Location = new System.Drawing.Point(6, 19);
            this.chkTipKarte1.Name = "chkTipKarte1";
            this.chkTipKarte1.Size = new System.Drawing.Size(77, 17);
            this.chkTipKarte1.TabIndex = 3;
            this.chkTipKarte1.Text = "Tip karte 1";
            this.chkTipKarte1.UseVisualStyleBackColor = true;
            // 
            // btnDodajNovi
            // 
            this.btnDodajNovi.Location = new System.Drawing.Point(263, 280);
            this.btnDodajNovi.Name = "btnDodajNovi";
            this.btnDodajNovi.Size = new System.Drawing.Size(75, 23);
            this.btnDodajNovi.TabIndex = 4;
            this.btnDodajNovi.Text = "Dodaj novi";
            this.btnDodajNovi.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(344, 280);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // grpTipoviKarata
            // 
            this.grpTipoviKarata.Controls.Add(this.chkTipKarte1);
            this.grpTipoviKarata.Controls.Add(this.chkTipKarte2);
            this.grpTipoviKarata.Controls.Add(this.chkTipKarte3);
            this.grpTipoviKarata.Location = new System.Drawing.Point(32, 58);
            this.grpTipoviKarata.Name = "grpTipoviKarata";
            this.grpTipoviKarata.Size = new System.Drawing.Size(387, 216);
            this.grpTipoviKarata.TabIndex = 6;
            this.grpTipoviKarata.TabStop = false;
            this.grpTipoviKarata.Text = "Tipovi karata";
            // 
            // chkTipKarte2
            // 
            this.chkTipKarte2.AutoSize = true;
            this.chkTipKarte2.Location = new System.Drawing.Point(6, 42);
            this.chkTipKarte2.Name = "chkTipKarte2";
            this.chkTipKarte2.Size = new System.Drawing.Size(77, 17);
            this.chkTipKarte2.TabIndex = 4;
            this.chkTipKarte2.Text = "Tip karte 2";
            this.chkTipKarte2.UseVisualStyleBackColor = true;
            // 
            // chkTipKarte3
            // 
            this.chkTipKarte3.AutoSize = true;
            this.chkTipKarte3.Location = new System.Drawing.Point(6, 65);
            this.chkTipKarte3.Name = "chkTipKarte3";
            this.chkTipKarte3.Size = new System.Drawing.Size(77, 17);
            this.chkTipKarte3.TabIndex = 5;
            this.chkTipKarte3.Text = "Tip karte 3";
            this.chkTipKarte3.UseVisualStyleBackColor = true;
            // 
            // FrmCjenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 307);
            this.Controls.Add(this.grpTipoviKarata);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodajNovi);
            this.Controls.Add(this.dtpDo);
            this.Controls.Add(this.dtpOd);
            this.Controls.Add(this.lblCjenikKarata);
            this.Name = "FrmCjenik";
            this.Text = "FrmCjenik";
            this.grpTipoviKarata.ResumeLayout(false);
            this.grpTipoviKarata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCjenikKarata;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.CheckBox chkTipKarte1;
        private System.Windows.Forms.Button btnDodajNovi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.GroupBox grpTipoviKarata;
        private System.Windows.Forms.CheckBox chkTipKarte2;
        private System.Windows.Forms.CheckBox chkTipKarte3;
    }
}