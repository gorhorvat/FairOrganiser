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
        /// Extract-a datume iz DateTimePickera i pristiskom na tipku Dodaj sprema novi cjenik u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajCjenik_Click(object sender, EventArgs e)
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
        private void btnObrisiCjenik_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Omogućuje pregled odabranog cjenika u novoj formi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            FrmPregledCjenika pregled = new FrmPregledCjenika();
            pregled.Show();
        }
    }
}
