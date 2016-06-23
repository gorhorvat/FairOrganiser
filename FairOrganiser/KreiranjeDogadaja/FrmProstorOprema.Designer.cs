namespace KreiranjeDogadaja
{
    partial class FrmProstorOprema
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProstorOprema));
            this.panelSlika = new System.Windows.Forms.Panel();
            this.lvSlike = new System.Windows.Forms.ListView();
            this.ilSlike = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelSlika
            // 
            this.panelSlika.BackgroundImage = global::KreiranjeDogadaja.Properties.Resources.prostor;
            this.panelSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelSlika.Location = new System.Drawing.Point(206, 12);
            this.panelSlika.Name = "panelSlika";
            this.panelSlika.Size = new System.Drawing.Size(768, 467);
            this.panelSlika.TabIndex = 0;
            this.panelSlika.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelSlika_DragDrop);
            this.panelSlika.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelSlika_DragEnter);
            // 
            // lvSlike
            // 
            this.lvSlike.LargeImageList = this.ilSlike;
            this.lvSlike.Location = new System.Drawing.Point(12, 12);
            this.lvSlike.Name = "lvSlike";
            this.lvSlike.Size = new System.Drawing.Size(188, 467);
            this.lvSlike.TabIndex = 1;
            this.lvSlike.UseCompatibleStateImageBehavior = false;
            this.lvSlike.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvSlike_MouseDown);
            // 
            // ilSlike
            // 
            this.ilSlike.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSlike.ImageStream")));
            this.ilSlike.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSlike.Images.SetKeyName(0, "pozornica.png");
            this.ilSlike.Images.SetKeyName(1, "rasvjeta.png");
            this.ilSlike.Images.SetKeyName(2, "stolice.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(495, 500);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Generiraj prikaz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmProstorOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvSlike);
            this.Controls.Add(this.panelSlika);
            this.Name = "FrmProstorOprema";
            this.Text = "FrmProstorOprema";
            this.Load += new System.EventHandler(this.FrmProstorOprema_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlika;
        private System.Windows.Forms.ListView lvSlike;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList ilSlike;
        private System.Windows.Forms.Button button2;
    }
}