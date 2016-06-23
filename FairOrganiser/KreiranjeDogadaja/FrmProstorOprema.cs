using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KreiranjeDogadaja
{
    public partial class FrmProstorOprema : Form
    {

        private static List<int> id =new List<int>();

        private static LogikaDogadaj logic;

        public FrmProstorOprema(LogikaDogadaj log)
        {
            logic = log;
            InitializeComponent();


            
        }

        private void FrmProstorOprema_Load(object sender, EventArgs e)
        {

            ListViewItem item1 = new ListViewItem("Pozornica", 0);
            ListViewItem item2 = new ListViewItem("Rasvjeta", 1);
            ListViewItem item3 = new ListViewItem("Stolice", 2);




            lvSlike.Items.AddRange(new ListViewItem[] { item1, item2, item3 });
            panelSlika.AllowDrop = true;


        }

        private void lvSlike_MouseDown(object sender, MouseEventArgs e)
        {
            var selectedItem = lvSlike.GetItemAt(e.X, e.Y);
            if (selectedItem != null)
            {
                var image = selectedItem.ImageIndex;
                DoDragDrop(ilSlike.Images.Keys[image].ToString(), DragDropEffects.Copy);
            }


        }

        private void panelSlika_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelSlika_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox p = new PictureBox();

            string imageName = e.Data.GetData(DataFormats.StringFormat).ToString();

            Bitmap bmp;
            

            switch (imageName)
            {

                case "pozornica.png":

                    bmp = new Bitmap(Properties.Resources.pozornica);
                    id.Add(11);

                    break;

                case "rasvjeta.png":

                    bmp = new Bitmap(Properties.Resources.rasvjeta);
                    id.Add(10);

                    break;

                case "stolice.png":

                    bmp = new Bitmap(Properties.Resources.stolice);
                    id.Add(3);

                    break;

                default:
                    return;


            }

            p.Size = bmp.Size;
            p.Image = bmp;
            p.Location = panelSlika.PointToClient(new Point(e.X, e.Y));
            p.Parent = panelSlika;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            logic.AddOprema(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Bitmap bmp = new Bitmap(panelSlika.Width*2, panelSlika.Height);
            System.Drawing.Rectangle r = panelSlika.ClientRectangle;
            panelSlika.DrawToBitmap(bmp, r);
            

            logic.AddToPdf(bmp);
        }
    }
}
