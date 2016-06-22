using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EvidencijaSudionika
{
    public partial class FrmEvidencija : Form
    {
        public FrmEvidencija()
        {
            InitializeComponent();
        }

        private void FrmSudionik_Load(object sender, EventArgs e)
        {
            PrikaziSudionike();
        }

        /// <summary>
        /// Dohvaća listu sudionika te ih prikazuje u DGV-u.
        /// </summary>
        public void PrikaziSudionike()
        {
            BindingList<Sudionik> listaSudionika = null;
            using (var db = new EvidencijaSudionikaEntities())
            {
                listaSudionika = new BindingList<Sudionik>(db.Sudioniks.ToList());        
            }
            sudionikBindingSource.DataSource = listaSudionika;
        }

        /// <summary>
        /// Brisanje sudionika sa odabranim ID-om.
        /// </summary>
        /// <param name="SudionikID"></param>
        private void ObrisiSudionika(int SudionikID)
        {
            using (var db = new EvidencijaSudionikaEntities())
            {
                Sudionik brisiSudionik = (from s in db.Sudioniks
                                          where s.id == SudionikID
                                          select s).First();

                if (brisiSudionik != null)
                {
                    if (MessageBox.Show("Da li ste sigurni? ", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        db.Sudioniks.Remove(brisiSudionik);
                        db.SaveChanges();
                    }
                }
            }
        }
        /// <summary>
        /// Brisanje označenog sudionika sa liste te iz baze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzbrisiSudionika_Click(object sender, EventArgs e)
        {
            int SudionikID = int.Parse(dgvSudionici[0, dgvSudionici.CurrentRow.Index].Value.ToString());
            ObrisiSudionika(SudionikID);
            PrikaziSudionike();
        }
        /// <summary>
        /// Otvaranje forme za dodavanje novog sudionika te ažuriranje popisa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajSudionika_Click(object sender, EventArgs e)
        {
            FrmNoviSudionik noviSudionik = new FrmNoviSudionik();
            noviSudionik.ShowDialog();
            PrikaziSudionike();
        }
        /// <summary>
        /// Otvaranje forme za izdavanje akreditacije sa podacima odabranog sudionika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIzdajAkreditaciju_Click(object sender, EventArgs e)
        {
            int SudionikID = int.Parse(dgvSudionici[0, dgvSudionici.CurrentRow.Index].Value.ToString());
            Sudionik odabraniSudionik = (Sudionik)sudionikBindingSource.Current;
            FrmAkreditacija akreditacija = new FrmAkreditacija(odabraniSudionik,SudionikID);
            akreditacija.ShowDialog();
            PrikaziSudionike();
        }
    }
}

