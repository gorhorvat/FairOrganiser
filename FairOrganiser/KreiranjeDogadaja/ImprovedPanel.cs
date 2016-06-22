using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreiranjeDogadaja
{
    public partial class ImprovedPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;

        public int ID {get;set;}

        [DefaultValue(false)]
        public bool Selected { get; set; }

        [DefaultValue(false)]
        public bool Available { get; set; }

        public ImprovedPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        private int opacity = 50;
        [DefaultValue(50)]
        public int Opacity
        {
            get
            {
                return this.opacity;
            }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("value must be between 0 and 100");
                this.opacity = value;
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(this.opacity , this.BackColor)))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
            base.OnPaint(e);
        }


        protected override void OnMouseClick(MouseEventArgs e)
        {
            if(this.Available == false)
            {
                return;
            }
            Selected = !Selected;

            if(this.Selected == true)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.Green;
            }

            LogikaDogadaj.RefreshForm();

            LogikaDogadaj.AddToList(this);

            base.OnMouseClick(e);
        }

       
    }
}

