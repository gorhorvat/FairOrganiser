using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneriranjeIzvjesca
{
    public partial class FrmIzvjesca : Form
    {
        public FrmIzvjesca()
        {
            InitializeComponent();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (rbBrojPosjetitelja.Checked == true)
            {
                FrmIzvjesceBrojPosjetitelja brojPosjetitelja = new FrmIzvjesceBrojPosjetitelja();
                brojPosjetitelja.ShowDialog();
            }

            if (rbProdaneUsluge.Checked == true)
            {
                FrmIzvjesceProdaneUsluge prodaneUsluge = new FrmIzvjesceProdaneUsluge();
                prodaneUsluge.ShowDialog();
            }

            if (rbKapaciteti.Checked == true)
            {
                FrmIzvjescePopunjenostKapaciteta kapaciteti = new FrmIzvjescePopunjenostKapaciteta();
                kapaciteti.ShowDialog();
            }

            if (rbOrganizatori.Checked == true)
            {
                FrmIzvjesceOrganiziraniDogadaji dogadaji = new FrmIzvjesceOrganiziraniDogadaji();
                dogadaji.ShowDialog();
            }
        }
    }
}
