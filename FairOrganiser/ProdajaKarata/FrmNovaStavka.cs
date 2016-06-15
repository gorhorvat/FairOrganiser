using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmNovaStavka : Form
    {
        LogikaPK logika = new LogikaPK();

        public FrmNovaStavka()
        {
            InitializeComponent();
        }

        private void FrmNovaStavka_Load(object sender, EventArgs e)
        {
            SetSourceUsluge();
        }

        private void SetSourceUsluge()
        {
            uslugaBindingSource.DataSource = logika.PrikaziUsluge();
        }

        private void dgvUsluge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijena.Text = float.Parse(dgvUsluge[4, dgvUsluge.CurrentRow.Index].Value.ToString()).ToString("N", CultureInfo.InvariantCulture);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
