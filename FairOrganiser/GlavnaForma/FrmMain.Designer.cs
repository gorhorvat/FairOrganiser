namespace GlavnaForma
{
    partial class FrmMain
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
            this.btnOrganizatori = new System.Windows.Forms.Button();
            this.btnSudionici = new System.Windows.Forms.Button();
            this.btnCjenik = new System.Windows.Forms.Button();
            this.btnIzvjesce = new System.Windows.Forms.Button();
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnKarta = new System.Windows.Forms.Button();
            this.btnDogadaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrganizatori
            // 
            this.btnOrganizatori.Location = new System.Drawing.Point(12, 38);
            this.btnOrganizatori.Name = "btnOrganizatori";
            this.btnOrganizatori.Size = new System.Drawing.Size(75, 23);
            this.btnOrganizatori.TabIndex = 0;
            this.btnOrganizatori.Text = "Organizatori";
            this.btnOrganizatori.UseVisualStyleBackColor = true;
            // 
            // btnSudionici
            // 
            this.btnSudionici.Location = new System.Drawing.Point(12, 89);
            this.btnSudionici.Name = "btnSudionici";
            this.btnSudionici.Size = new System.Drawing.Size(75, 23);
            this.btnSudionici.TabIndex = 1;
            this.btnSudionici.Text = "Sudionici";
            this.btnSudionici.UseVisualStyleBackColor = true;
            // 
            // btnCjenik
            // 
            this.btnCjenik.Location = new System.Drawing.Point(12, 139);
            this.btnCjenik.Name = "btnCjenik";
            this.btnCjenik.Size = new System.Drawing.Size(75, 23);
            this.btnCjenik.TabIndex = 2;
            this.btnCjenik.Text = "Cjenik";
            this.btnCjenik.UseVisualStyleBackColor = true;
            // 
            // btnIzvjesce
            // 
            this.btnIzvjesce.Location = new System.Drawing.Point(12, 193);
            this.btnIzvjesce.Name = "btnIzvjesce";
            this.btnIzvjesce.Size = new System.Drawing.Size(75, 23);
            this.btnIzvjesce.TabIndex = 3;
            this.btnIzvjesce.Text = "Izvješće";
            this.btnIzvjesce.UseVisualStyleBackColor = true;
            // 
            // btnRacun
            // 
            this.btnRacun.Location = new System.Drawing.Point(12, 245);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(75, 23);
            this.btnRacun.TabIndex = 4;
            this.btnRacun.Text = "Račun";
            this.btnRacun.UseVisualStyleBackColor = true;
            // 
            // btnKarta
            // 
            this.btnKarta.Location = new System.Drawing.Point(12, 294);
            this.btnKarta.Name = "btnKarta";
            this.btnKarta.Size = new System.Drawing.Size(75, 23);
            this.btnKarta.TabIndex = 5;
            this.btnKarta.Text = "Karta";
            this.btnKarta.UseVisualStyleBackColor = true;
            // 
            // btnDogadaj
            // 
            this.btnDogadaj.Location = new System.Drawing.Point(12, 347);
            this.btnDogadaj.Name = "btnDogadaj";
            this.btnDogadaj.Size = new System.Drawing.Size(75, 23);
            this.btnDogadaj.TabIndex = 6;
            this.btnDogadaj.Text = "Dogadaj";
            this.btnDogadaj.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnDogadaj);
            this.Controls.Add(this.btnKarta);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.btnIzvjesce);
            this.Controls.Add(this.btnCjenik);
            this.Controls.Add(this.btnSudionici);
            this.Controls.Add(this.btnOrganizatori);
            this.Name = "FrmMain";
            this.Text = "Glavni izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrganizatori;
        private System.Windows.Forms.Button btnSudionici;
        private System.Windows.Forms.Button btnCjenik;
        private System.Windows.Forms.Button btnIzvjesce;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnKarta;
        private System.Windows.Forms.Button btnDogadaj;
    }
}

