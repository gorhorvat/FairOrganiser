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
        public FrmCjenik()
        {
            InitializeComponent();
        }

        private void FrmCjenik_Load(object sender, EventArgs e)
        {
            PrikaziCjenike();
        }

        /// <summary>
        /// Dohvaća listu svih cjenika događaja u kontekstu, te ih prikazuje u DataGridView-u.
        /// </summary>
        private void PrikaziCjenike()
        {
            BindingList<CjenikDogadaja> popisCjenika = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisCjenika = new BindingList<CjenikDogadaja>(db.CjenikDogadajas.ToList());
            }
            cjenikDogadajaBindingSource.DataSource = popisCjenika;
        }

        /// <summary>
        /// Dohvaća cjenik sa odabranim ID-om i briše ga iz baze
        /// </summary>
        /// <param name="CjenikID"></param>
        public void ObrisiCjenik(int CjenikID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                CjenikDogadaja brisiCjenik = (from c in db.CjenikDogadajas
                                                where c.id == CjenikID
                                                select c).First();
                if (brisiCjenik != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.CjenikDogadajas.Remove(brisiCjenik);
                        db.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Extract-a datume iz DateTimePickera i pristiskom na tipku Dodaj sprema novi cjenik u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnDodajCjenik_Click(object sender, EventArgs e)
        {
            using (var db = new ProdajaKarataEntities())
            {
                CjenikDogadaja noviCjenik = new CjenikDogadaja
                {
                    vrijediOd = dtpOd.Value.Date,
                    vrijediDo = dtpDo.Value.Date
                };
                db.CjenikDogadajas.Add(noviCjenik);
                db.SaveChanges();
            }
            PrikaziCjenike();
        }
        /// <summary>
        /// Briše selektirani cjenik iz DataGridView-a te iz baze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnObrisiCjenik_Click(object sender, EventArgs e)
        {
            int CjenikID = int.Parse(dgvPopisCjenika[0, dgvPopisCjenika.CurrentRow.Index].Value.ToString());
            ObrisiCjenik(CjenikID);
            PrikaziCjenike();
        }
        /// <summary>
        /// Omogućuje pregled odabranog cjenika u novoj formi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            int CjenikID = int.Parse(dgvPopisCjenika[0, dgvPopisCjenika.CurrentRow.Index].Value.ToString());
            CjenikDogadaja odabraniCjenik = (CjenikDogadaja)cjenikDogadajaBindingSource.Current;
            FrmPregledCjenika pregled = new FrmPregledCjenika(odabraniCjenik, CjenikID);
            pregled.Show();
        }
    }
}
