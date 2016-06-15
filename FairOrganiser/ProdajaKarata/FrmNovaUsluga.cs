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
    public partial class FrmNovaUsluga : Form
    {
        LogikaPK logika = new LogikaPK();

        public FrmNovaUsluga()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            logika.DodajNovuUslugu(txtNazivUsluge.Text, txtTipUsluge.Text, txtNapomena.Text, float.Parse(txtCijenaUsluge.Text));
            Close();
        }
    }
}
