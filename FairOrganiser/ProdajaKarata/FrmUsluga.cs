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
    public partial class FrmUsluga : Form
    {
        public FrmUsluga()
        {
            InitializeComponent();
        }

        private void FrmUsluga_Load(object sender, EventArgs e)
        {
            PrikaziUsluge();
        }
        /// <summary>
        /// Dohvaća listu svih usluga u kontekstu, te ih prikazuje u DataGridView-u.
        /// </summary>
        private void PrikaziUsluge()
        {
            BindingList<Usluga> popisUsluga = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisUsluga = new BindingList<Usluga>(db.Uslugas.ToList());
            }
            uslugaBindingSource.DataSource = popisUsluga;
        }

        /// <summary>
        /// Dohvaća uslugu sa odabranim ID-om i briše je iz baze
        /// </summary>
        /// <param name="UslugaID"></param>
        public void ObrisiUslugu(int UslugaID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                Usluga brisiUslugu = (from b in db.Uslugas
                                              where b.id == UslugaID
                                              select b).First();
                if (brisiUslugu != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Uslugas.Remove(brisiUslugu);
                        db.SaveChanges();
                    }
                }
            }
        }

        private void btnObrisiUslugu_Click(object sender, EventArgs e)
        {
            int UslugaID = int.Parse(dgvUsluge[0, dgvUsluge.CurrentRow.Index].Value.ToString());
            ObrisiUslugu(UslugaID);
            PrikaziUsluge();
        }

        private void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            FrmNovaUsluga novaUsluga = new FrmNovaUsluga();
            novaUsluga.ShowDialog();
            PrikaziUsluge();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
