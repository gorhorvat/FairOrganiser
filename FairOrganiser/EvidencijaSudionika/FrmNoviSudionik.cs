using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvidencijaSudionika
{
    public partial class FrmNoviSudionik : Form
    {
        public FrmNoviSudionik()
        {
            InitializeComponent();
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
                    telefon = txtTelefon.Text,
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
    }
}
