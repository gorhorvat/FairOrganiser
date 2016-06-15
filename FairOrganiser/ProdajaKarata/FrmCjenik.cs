using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmCjenik : Form
    {
        LogikaPK logika = new LogikaPK();

        public FrmCjenik()
        {
            InitializeComponent();
        }

        private void FrmCjenik_Load(object sender, EventArgs e)
        {
            SetSourceCjenici();
        }

        private void SetSourceCjenici()
        {
            cjenikDogadajaBindingSource.DataSource = logika.PrikaziCjenike();
        }

        public void btnDodajCjenik_Click(object sender, EventArgs e)
        {
            logika.DodajCjenik(dtpOd.Value.Date, dtpDo.Value.Date);
            SetSourceCjenici();
        }

        public void btnObrisiCjenik_Click(object sender, EventArgs e)
        {
            int CjenikID = int.Parse(dgvPopisCjenika[0, dgvPopisCjenika.CurrentRow.Index].Value.ToString());
            logika.ObrisiCjenik(CjenikID);
            SetSourceCjenici();
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            int CjenikID = int.Parse(dgvPopisCjenika[0, dgvPopisCjenika.CurrentRow.Index].Value.ToString());
            CjenikDogadaja odabraniCjenik = (CjenikDogadaja)cjenikDogadajaBindingSource.Current;
            FrmPregledCjenika pregled = new FrmPregledCjenika(odabraniCjenik, CjenikID);
            pregled.ShowDialog();
        }
    }
}
