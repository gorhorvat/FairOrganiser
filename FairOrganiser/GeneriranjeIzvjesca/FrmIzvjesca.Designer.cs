namespace GeneriranjeIzvjesca
{
    partial class FrmIzvjesca
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbOrganizatori = new System.Windows.Forms.RadioButton();
            this.rbKapaciteti = new System.Windows.Forms.RadioButton();
            this.rbProdaneUsluge = new System.Windows.Forms.RadioButton();
            this.rbBrojPosjetitelja = new System.Windows.Forms.RadioButton();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbOrganizatori);
            this.panel1.Controls.Add(this.rbKapaciteti);
            this.panel1.Controls.Add(this.rbProdaneUsluge);
            this.panel1.Controls.Add(this.rbBrojPosjetitelja);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 98);
            this.panel1.TabIndex = 0;
            // 
            // rbOrganizatori
            // 
            this.rbOrganizatori.AutoSize = true;
            this.rbOrganizatori.Location = new System.Drawing.Point(3, 72);
            this.rbOrganizatori.Name = "rbOrganizatori";
            this.rbOrganizatori.Size = new System.Drawing.Size(195, 17);
            this.rbOrganizatori.TabIndex = 3;
            this.rbOrganizatori.TabStop = true;
            this.rbOrganizatori.Text = "Izvješće o organiziranim događajima";
            this.rbOrganizatori.UseVisualStyleBackColor = true;
            // 
            // rbKapaciteti
            // 
            this.rbKapaciteti.AutoSize = true;
            this.rbKapaciteti.Location = new System.Drawing.Point(3, 49);
            this.rbKapaciteti.Name = "rbKapaciteti";
            this.rbKapaciteti.Size = new System.Drawing.Size(189, 17);
            this.rbKapaciteti.TabIndex = 2;
            this.rbKapaciteti.TabStop = true;
            this.rbKapaciteti.Text = "Izvješće o popunjenosti kapaciteta";
            this.rbKapaciteti.UseVisualStyleBackColor = true;
            // 
            // rbProdaneUsluge
            // 
            this.rbProdaneUsluge.AutoSize = true;
            this.rbProdaneUsluge.Location = new System.Drawing.Point(3, 26);
            this.rbProdaneUsluge.Name = "rbProdaneUsluge";
            this.rbProdaneUsluge.Size = new System.Drawing.Size(167, 17);
            this.rbProdaneUsluge.TabIndex = 1;
            this.rbProdaneUsluge.TabStop = true;
            this.rbProdaneUsluge.Text = "Izvješće o prodanim uslugama";
            this.rbProdaneUsluge.UseVisualStyleBackColor = true;
            // 
            // rbBrojPosjetitelja
            // 
            this.rbBrojPosjetitelja.AutoSize = true;
            this.rbBrojPosjetitelja.Location = new System.Drawing.Point(3, 3);
            this.rbBrojPosjetitelja.Name = "rbBrojPosjetitelja";
            this.rbBrojPosjetitelja.Size = new System.Drawing.Size(151, 17);
            this.rbBrojPosjetitelja.TabIndex = 0;
            this.rbBrojPosjetitelja.TabStop = true;
            this.rbBrojPosjetitelja.Text = "Izvješće o broju posjetitelja";
            this.rbBrojPosjetitelja.UseVisualStyleBackColor = true;
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(58, 116);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 1;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(139, 116);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FrmIzvjesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 147);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.panel1);
            this.Name = "FrmIzvjesca";
            this.Text = "Popis izvješća";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbOrganizatori;
        private System.Windows.Forms.RadioButton rbKapaciteti;
        private System.Windows.Forms.RadioButton rbProdaneUsluge;
        private System.Windows.Forms.RadioButton rbBrojPosjetitelja;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Button btnIzlaz;
    }
}