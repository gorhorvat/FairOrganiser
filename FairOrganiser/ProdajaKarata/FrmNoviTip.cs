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
    public partial class FrmNoviTip : Form
    {
        LogikaPK logika = new LogikaPK();

        private int CjenikID;

        public FrmNoviTip(int cjenikID)
        {
            CjenikID = cjenikID;
            InitializeComponent();
        }
        /// <summary>
        /// Dodaje novi tip karte u listu tipova karata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            using (var db = new ProdajaKarataEntities())
            {
                TipKarte noviTip = new TipKarte
                {
                    iznosPopusta = int.Parse(txtIznosPopusta.Text),
                    naziv = txtNazivTipa.Text,
                    CjenikDogadajaid = CjenikID
                };
                db.TipKartes.Add(noviTip);
                db.SaveChanges();
            }
            Close();
        }
    }
}
