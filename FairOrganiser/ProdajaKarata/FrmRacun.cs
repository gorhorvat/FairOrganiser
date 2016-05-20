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
    public partial class FrmRacun : Form
    {
        
        //private Usluga novaStavka;

        public FrmRacun()
        {
            InitializeComponent();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            FrmNovaStavka novaStavka = new FrmNovaStavka();
            novaStavka.ShowDialog();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {

        }
    }
}
