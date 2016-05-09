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
    public partial class FrmNovaStavka : Form
    {
        public FrmNovaStavka()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
