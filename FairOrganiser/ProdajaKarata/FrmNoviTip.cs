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
        private int cjenikID;

        public FrmNoviTip()
        {
            //cjenikID = CjenikID;
            InitializeComponent();
        }
        /// <summary>
        /// Ne radi!!!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            /*using (var db = new ProdajaKarataEntities())
            {
                TipKarte noviTip = new TipKarte
                {
                    iznosPopusta = int.Parse(txtIznosPopusta.Text),
                    naziv = txtNazivTipa.Text,
                    //CjenikDogadajaid = 
                };
                db.TipKartes.Add(noviTip);
                db.SaveChanges();
            }*/
            Close();
        }
    }
}
