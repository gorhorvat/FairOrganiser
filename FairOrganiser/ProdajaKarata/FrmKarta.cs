using Baza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmKarta : Form
    {
        LogikaPK _logikaPK;

        public FrmKarta(LogikaPK logikaPK)
        {
            _logikaPK = logikaPK;
            InitializeComponent();
        }

        public void SetDataSource(List<Dogadaj> dogadaj, List<TipKarte> tip, string sifraKarte)
        {
            dgvPopisDogadaja.DataSource = dogadaj.Select(d => new { Naziv = d.Naziv }).ToList();
            dgvPopisTipova.DataSource = tip.Select(t => new { Naziv = t.Naziv }).ToList();
            txtSifraKarte.Text = sifraKarte;
            txtDatum.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss");
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Karta k = new Karta(DateTime.Parse(txtDatum.Text));
            _logikaPK.SaveKarta(k);
            Close();
        }

        private void dgvPopisDogadaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijenaKarte.Text = _logikaPK.GetCijenaKarte(dgvPopisDogadaja.CurrentCell.RowIndex, dgvPopisTipova.CurrentCell.RowIndex).ToString("N", CultureInfo.InvariantCulture);
        }

        private void dgvPopisTipova_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijenaKarte.Text = _logikaPK.GetCijenaKarte(dgvPopisDogadaja.CurrentCell.RowIndex, dgvPopisTipova.CurrentCell.RowIndex).ToString("N", CultureInfo.InvariantCulture);
        }
    }
}
