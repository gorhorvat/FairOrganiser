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
        public FrmKarta()
        {
            InitializeComponent();
        }

        private void FrmKarta_Load(object sender, EventArgs e)
        {
            txtSifraKarte.Text = GetSifra().ToString();
            txtDatum.Text = DateTime.Now.ToString("dd/MM/yyyy   hh:mm:ss");
            PrikaziDogadaje();
            PrikaziTipove();
        }

        /// <summary>
        /// Dohvaća broj karata u bazi uvećan za 1
        /// </summary>
        public int GetSifra()
        {
            using (var db = new ProdajaKarataEntities())
            {
                int sifra = (from s in db.Kartas select s).Count()+1;
                return sifra;
            }
        }

        /// <summary>
        /// Dohvaća listu svih događaja u kontekstu, te ih prikazuje u DataGridView-u.
        /// </summary>
        private void PrikaziDogadaje()
        {
            BindingList<Dogadaj> popisDogadaja = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisDogadaja = new BindingList<Dogadaj>(db.Dogadajs.ToList());
            }
            dogadajBindingSource.DataSource = popisDogadaja;
        }

        /// <summary>
        /// Dohvaća listu svih tipova karata u kontekstu, te ih prikazuje u DataGridView-u.
        /// </summary>
        private void PrikaziTipove()
        {
            BindingList<TipKarte> popisTipova = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisTipova = new BindingList<TipKarte>(db.TipKartes.ToList());
            }
            tipKarteBindingSource.DataSource = popisTipova;
        }
        /// <summary>
        /// Dohvaća cijenu jedne karte sa uračunatim popustom.
        /// </summary>
        /// <param name="cijena"></param>
        /// <param name="popust"></param>
        /// <returns></returns>
        public float GetCijenaKarte(float cijena, float popust)
        {
            float cijenaKarte = (float)cijena - ((float)cijena * ((float)popust / 100));
            return cijenaKarte;
        }

        public void dgvPopisDogadaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijenaKarte.Text = GetCijenaKarte(float.Parse(dgvPopisDogadaja[4, dgvPopisDogadaja.CurrentRow.Index].Value.ToString()), float.Parse(dgvPopisTipova[1, dgvPopisTipova.CurrentRow.Index].Value.ToString())).ToString("N", CultureInfo.InvariantCulture);
        }

        public void dgvPopisTipova_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijenaKarte.Text = GetCijenaKarte(float.Parse(dgvPopisDogadaja[4, dgvPopisDogadaja.CurrentRow.Index].Value.ToString()), float.Parse(dgvPopisTipova[1, dgvPopisTipova.CurrentRow.Index].Value.ToString())).ToString("N", CultureInfo.InvariantCulture);
        }
        /// <summary>
        /// Sprema instancu karte u bazu zajedno sa vanjskim ključevima.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIspisi_Click(object sender, EventArgs e)
        {
            using (var db = new ProdajaKarataEntities())
            {
                Karta novaKarta = new Karta
                {
                    datum = DateTime.Parse(txtDatum.Text),
                    Dogadajid = int.Parse(dgvPopisDogadaja[0, dgvPopisDogadaja.CurrentRow.Index].Value.ToString()),
                    Cjenikid = int.Parse(dgvPopisTipova[3, dgvPopisTipova.CurrentRow.Index].Value.ToString())
                };
                db.Kartas.Add(novaKarta);
                db.SaveChanges();
            }
            Close();
        }
    }
}