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
    public partial class FrmUsluga : Form
    {
        LogikaPK logika = new LogikaPK();

        public FrmUsluga()
        {
            InitializeComponent();
        }

        private void FrmUsluga_Load(object sender, EventArgs e)
        {
            SetSourceUsluge();
        }
       
        private void SetSourceUsluge()
        {
            uslugaBindingSource.DataSource = logika.PrikaziUsluge();
        }

        private void btnObrisiUslugu_Click(object sender, EventArgs e)
        {
            int UslugaID = int.Parse(dgvUsluge[0, dgvUsluge.CurrentRow.Index].Value.ToString());
            logika.ObrisiUslugu(UslugaID);
            SetSourceUsluge();
        }

        private void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            FrmNovaUsluga novaUsluga = new FrmNovaUsluga();
            novaUsluga.ShowDialog();
            SetSourceUsluge();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
