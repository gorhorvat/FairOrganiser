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
    public partial class FrmPregledCjenika : Form
    {
        LogikaPK logika = new LogikaPK();

        private CjenikDogadaja odabraniCjenik;
        private int cjenikID;

        public FrmPregledCjenika(CjenikDogadaja OdabraniCjenik, int CjenikID)
        {
            odabraniCjenik = OdabraniCjenik;
            cjenikID = CjenikID;
            InitializeComponent();
        }

        private void FrmPregledCjenika_Load(object sender, EventArgs e)
        {
            PrikaziTipove(cjenikID);
            DateTime Od = (DateTime)odabraniCjenik.vrijediOd;
            DateTime Do = (DateTime)odabraniCjenik.vrijediDo;
            txtOd.Text = Od.ToShortDateString();
            txtDo.Text = Do.ToShortDateString();   
        }

        /// <summary>
        /// Dohvaća listu svih tipova karata u kontekstu, te ih prikazuje u DataGridView-u.
        /// </summary>
        public void PrikaziTipove(int CjenikID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                CjenikDogadaja cjenici = (from c in db.CjenikDogadajas
                                     where c.id == CjenikID
                                     select c).First<CjenikDogadaja>();
                BindingList<TipKarte> popisTipova = new BindingList<TipKarte>(cjenici.TipKartes.ToList<TipKarte>());
                tipKarteBindingSource.DataSource = popisTipova;
            }
        }
        
        private void btnDodajTip_Click(object sender, EventArgs e)
        {
            FrmNoviTip noviTip = new FrmNoviTip(cjenikID);
            noviTip.ShowDialog();
            PrikaziTipove(cjenikID);
        }

        private void btnObrisiTip_Click(object sender, EventArgs e)
        {
            int TipID = int.Parse(dgvOdabraniCjenik[0, dgvOdabraniCjenik.CurrentRow.Index].Value.ToString());
            logika.ObrisiTip(TipID);
            PrikaziTipove(cjenikID);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
