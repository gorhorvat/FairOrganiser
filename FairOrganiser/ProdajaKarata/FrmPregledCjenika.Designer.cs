namespace ProdajaKarata
{
    partial class FrmPregledCjenika
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
            this.btnObrisiTip = new System.Windows.Forms.Button();
            this.btnDodajTip = new System.Windows.Forms.Button();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.txtDo = new System.Windows.Forms.TextBox();
            this.txtOd = new System.Windows.Forms.TextBox();
            this.lblCjenik = new System.Windows.Forms.Label();
            this.dgvOdabraniCjenik = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniCjenik)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisiTip
            // 
            this.btnObrisiTip.Location = new System.Drawing.Point(169, 231);
            this.btnObrisiTip.Name = "btnObrisiTip";
            this.btnObrisiTip.Size = new System.Drawing.Size(75, 23);
            this.btnObrisiTip.TabIndex = 13;
            this.btnObrisiTip.Text = "Obriši tip";
            this.btnObrisiTip.UseVisualStyleBackColor = true;
            // 
            // btnDodajTip
            // 
            this.btnDodajTip.Location = new System.Drawing.Point(88, 231);
            this.btnDodajTip.Name = "btnDodajTip";
            this.btnDodajTip.Size = new System.Drawing.Size(75, 23);
            this.btnDodajTip.TabIndex = 12;
            this.btnDodajTip.Text = "Dodaj tip";
            this.btnDodajTip.UseVisualStyleBackColor = true;
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(250, 231);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(75, 23);
            this.btnPotvrdi.TabIndex = 11;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(225, 7);
            this.txtDo.Name = "txtDo";
            this.txtDo.ReadOnly = true;
            this.txtDo.Size = new System.Drawing.Size(100, 20);
            this.txtDo.TabIndex = 10;
            // 
            // txtOd
            // 
            this.txtOd.Location = new System.Drawing.Point(119, 7);
            this.txtOd.Name = "txtOd";
            this.txtOd.ReadOnly = true;
            this.txtOd.Size = new System.Drawing.Size(100, 20);
            this.txtOd.TabIndex = 9;
            // 
            // lblCjenik
            // 
            this.lblCjenik.AutoSize = true;
            this.lblCjenik.Location = new System.Drawing.Point(74, 10);
            this.lblCjenik.Name = "lblCjenik";
            this.lblCjenik.Size = new System.Drawing.Size(39, 13);
            this.lblCjenik.TabIndex = 8;
            this.lblCjenik.Text = "Cjenik:";
            // 
            // dgvOdabraniCjenik
            // 
            this.dgvOdabraniCjenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniCjenik.Location = new System.Drawing.Point(88, 36);
            this.dgvOdabraniCjenik.Name = "dgvOdabraniCjenik";
            this.dgvOdabraniCjenik.Size = new System.Drawing.Size(237, 189);
            this.dgvOdabraniCjenik.TabIndex = 7;
            // 
            // FrmPregledCjenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 261);
            this.Controls.Add(this.btnObrisiTip);
            this.Controls.Add(this.btnDodajTip);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.txtDo);
            this.Controls.Add(this.txtOd);
            this.Controls.Add(this.lblCjenik);
            this.Controls.Add(this.dgvOdabraniCjenik);
            this.Name = "FrmPregledCjenika";
            this.Text = "Pregled cjenika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniCjenik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisiTip;
        private System.Windows.Forms.Button btnDodajTip;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.TextBox txtDo;
        private System.Windows.Forms.TextBox txtOd;
        private System.Windows.Forms.Label lblCjenik;
        private System.Windows.Forms.DataGridView dgvOdabraniCjenik;
    }
}