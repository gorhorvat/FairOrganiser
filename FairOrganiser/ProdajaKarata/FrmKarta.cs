using Baza;
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
    public partial class FrmKarta : Form
    {
        LogikaPK _logikaPK;

        public FrmKarta(LogikaPK logikaPK)
        {
            _logikaPK = logikaPK;
            InitializeComponent();
        }

        public void SetDataSource(List<Dogadaj> dogadaj, List<TipKarte> tip)
        {
            dgvPopisDogadaja.DataSource = dogadaj.Select(d => new { Naziv = d.Naziv }).ToList();
            dgvPopisTipova.DataSource = tip.Select(t => new { Naziv = t.Naziv }).ToList();
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
