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
    public partial class FrmNovaUsluga : Form
    {
        public FrmNovaUsluga()
        {
            InitializeComponent();
        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            using (var db = new ProdajaKarataEntities())
            {
                Usluga novaUsluga = new Usluga
                {
                    naziv = txtNazivUsluge.Text,
                    tip = txtTipUsluge.Text,
                    napomena = txtNapomena.Text,
                    cijenaUsluge = float.Parse(txtCijenaUsluge.Text)
                };
                db.Uslugas.Add(novaUsluga);
                db.SaveChanges();
            }
            Close();
        }
    }
}
