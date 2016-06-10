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
        private CjenikDogadaja odabraniCjenik;

        public FrmPregledCjenika(CjenikDogadaja OdabraniCjenik)
        {
            odabraniCjenik = OdabraniCjenik;
            InitializeComponent();
        }

        private void FrmPregledCjenika_Load(object sender, EventArgs e)
        {
            PrikaziTipove();
            DateTime Od = (DateTime)odabraniCjenik.vrijediOd;
            DateTime Do = (DateTime)odabraniCjenik.vrijediDo;
            txtOd.Text = Od.ToShortDateString();
            txtDo.Text = Do.ToShortDateString();   
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
        /// Ne radi baš!!!
        /// </summary>
        /// <param name="TipID"></param>
        /*public void ObrisiTip(int TipID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                TipKarte brisiTip = (from t in db.TipKartes
                                              where t.id == TipID
                                              select t).First();
                if (brisiTip != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.TipKartes.Remove(brisiTip);
                        db.SaveChanges();
                    }
                }
            }
        }*/
        
        private void btnDodajTip_Click(object sender, EventArgs e)
        {
            //int CjenikID = 
            FrmNoviTip noviTip = new FrmNoviTip();
            noviTip.Show();
        }

        private void btnObrisiTip_Click(object sender, EventArgs e)
        {
            int TipID = int.Parse(dgvOdabraniCjenik[0, dgvOdabraniCjenik.CurrentRow.Index].Value.ToString());
            //ObrisiTip(TipID);
            PrikaziTipove();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
