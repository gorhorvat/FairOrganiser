using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmCjenik : Form
    {
       
        //private Cjenik noviCjenik;

        public FrmCjenik()
        {
            InitializeComponent();
        }

        private void btnDodajNovi_Click(object sender, EventArgs e)
        {
            FrmNoviTip noviTip = new FrmNoviTip();
            noviTip.ShowDialog();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }
    }
}
