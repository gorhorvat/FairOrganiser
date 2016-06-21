using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace EvidencijaSudionika
{
    public partial class FrmNoviSudionik : Form
    {
        public FrmNoviSudionik()
        {
            InitializeComponent();
            mtxtTelefon.Mask = "000-000-0009";
        }
        /// <summary>
        /// Dodavanje sudionika u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajSudionika_Click(object sender, EventArgs e)
        {
            using (var db = new EvidencijaSudionikaEntities())
            {
                Sudionik noviSudionik = new Sudionik
                {
                    ime = txtImeSudionika.Text,
                    prezime = txtPrezimeSudionika.Text,
                    medijskaKuca = txtMedKuca.Text,
                    telefon = mtxtTelefon.Text,
                    email = txtEmail.Text,
                    dogadaj = cmbDogadaj.Text,                  
                };
                db.Sudioniks.Add(noviSudionik);
                db.SaveChanges();
            }
            Close();
        }

        /// <summary>
        /// Dohvaća listu svih događaja iz kolekcije događaja u kontekstu, te ih prikazuje u combobox-u.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviSudionik_Load(object sender, EventArgs e)
        {
            BindingList<Dogadaj> listaDogadaja = null;
            using (var db = new EvidencijaSudionikaEntities())
            {
                listaDogadaja = new BindingList<Dogadaj>(db.Dogadajs.ToList());
            }
            dogadajBindingSource.DataSource = listaDogadaja;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
