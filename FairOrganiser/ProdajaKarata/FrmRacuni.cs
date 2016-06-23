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
    public partial class FrmRacuni : Form
    {
        LogikaPK logika = new LogikaPK();
        Zaposlenik aktivni;

        public FrmRacuni(Zaposlenik aktivniZaposlenik)
        {
            aktivni = aktivniZaposlenik;
            InitializeComponent();
        }

        private void FrmRacuni_Load(object sender, EventArgs e)
        {
            SetSourceRacuni();
        }

        private void SetSourceRacuni()
        {
            racunBindingSource.DataSource = logika.PrikaziRacune();
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            int RacunID = int.Parse(dgvPopisRacuna[0, dgvPopisRacuna.CurrentRow.Index].Value.ToString());
            string NazivKupca = dgvPopisRacuna[4, dgvPopisRacuna.CurrentRow.Index].Value.ToString();
            Racun odabraniRacun = (Racun)racunBindingSource.Current;
            FrmPrikazRacuna prikaz = new FrmPrikazRacuna(odabraniRacun, RacunID, NazivKupca);
            prikaz.ShowDialog();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
