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
    public partial class FrmRacun : Form
    {
        LogikaPK _logikaPK;

        public FrmRacun(LogikaPK logikaPK)
        {
            _logikaPK = logikaPK;
            InitializeComponent();
        }

        public void SetDataSource(List<Racun> racun, string brojRacuna)
        {
            dgvListaStavki.DataSource = racun;
            txtBrojRacuna.Text = brojRacuna;
            txtVrijeme.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss");
        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            _logikaPK.StartNovaStavka();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {

        }
    }
}
