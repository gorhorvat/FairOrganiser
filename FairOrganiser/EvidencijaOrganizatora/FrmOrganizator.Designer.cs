namespace EvidencijaOrganizatora
{
    partial class FrmOrganizator
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
            this.dgvOrganizatori = new System.Windows.Forms.DataGridView();
            this.btnObrisiOrganizatora = new System.Windows.Forms.Button();
            this.btnNoviOrganizator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrganizatori
            // 
            this.dgvOrganizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrganizatori.Location = new System.Drawing.Point(46, 6);
            this.dgvOrganizatori.Name = "dgvOrganizatori";
            this.dgvOrganizatori.Size = new System.Drawing.Size(352, 192);
            this.dgvOrganizatori.TabIndex = 6;
            // 
            // btnObrisiOrganizatora
            // 
            this.btnObrisiOrganizatora.Location = new System.Drawing.Point(229, 213);
            this.btnObrisiOrganizatora.Name = "btnObrisiOrganizatora";
            this.btnObrisiOrganizatora.Size = new System.Drawing.Size(78, 41);
            this.btnObrisiOrganizatora.TabIndex = 5;
            this.btnObrisiOrganizatora.Text = "Obriši organizatora";
            this.btnObrisiOrganizatora.UseVisualStyleBackColor = true;
            // 
            // btnNoviOrganizator
            // 
            this.btnNoviOrganizator.Location = new System.Drawing.Point(313, 213);
            this.btnNoviOrganizator.Name = "btnNoviOrganizator";
            this.btnNoviOrganizator.Size = new System.Drawing.Size(85, 42);
            this.btnNoviOrganizator.TabIndex = 4;
            this.btnNoviOrganizator.Text = "Novi organizator";
            this.btnNoviOrganizator.UseVisualStyleBackColor = true;
            // 
            // FrmOrganizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 261);
            this.Controls.Add(this.dgvOrganizatori);
            this.Controls.Add(this.btnObrisiOrganizatora);
            this.Controls.Add(this.btnNoviOrganizator);
            this.Name = "FrmOrganizator";
            this.Text = "Organizatori";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrganizatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrganizatori;
        private System.Windows.Forms.Button btnObrisiOrganizatora;
        private System.Windows.Forms.Button btnNoviOrganizator;
    }
}

