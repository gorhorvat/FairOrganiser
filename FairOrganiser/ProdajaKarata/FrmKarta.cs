using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmKarta : Form
    {
        LogikaPK logika = new LogikaPK();

        public FrmKarta()
        {
            InitializeComponent();
        }

        private void FrmKarta_Load(object sender, EventArgs e)
        {
            txtSifraKarte.Text = logika.GetSifraKarte().ToString();
            txtDatum.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss");
            SetSourceDogadaji();
            SetSourceTipovi();
        }

        private void SetSourceDogadaji()
        {
            dogadajBindingSource.DataSource = logika.PrikaziDogadaje();
        }

        private void SetSourceTipovi()
        {
            tipKarteBindingSource.DataSource = logika.PrikaziTipove();
        }

        private void dgvPopisDogadaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijenaKarte.Text = logika.GetCijenaKarte(float.Parse(dgvPopisDogadaja[4, dgvPopisDogadaja.CurrentRow.Index].Value.ToString()), float.Parse(dgvPopisTipova[1, dgvPopisTipova.CurrentRow.Index].Value.ToString())).ToString("N", CultureInfo.InvariantCulture);
        }

        private void dgvPopisTipova_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijenaKarte.Text = logika.GetCijenaKarte(float.Parse(dgvPopisDogadaja[4, dgvPopisDogadaja.CurrentRow.Index].Value.ToString()), float.Parse(dgvPopisTipova[1, dgvPopisTipova.CurrentRow.Index].Value.ToString())).ToString("N", CultureInfo.InvariantCulture);
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            logika.SpremiKartu(DateTime.Parse(txtDatum.Text), int.Parse(dgvPopisDogadaja[0, dgvPopisDogadaja.CurrentRow.Index].Value.ToString()), int.Parse(dgvPopisTipova[3, dgvPopisTipova.CurrentRow.Index].Value.ToString()));
            Close();
        }
    }
}