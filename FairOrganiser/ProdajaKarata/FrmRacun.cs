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
    public partial class FrmRacun : Form
    {
        public FrmRacun()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Dakle, forma Račun sadržava operatera - zaposlenik, naziv kupca - organizator, dgvStavkeRačuna - lista usluga (samo one označene kod odabira prostora i svih usluga za događaj)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRacun_Load(object sender, EventArgs e)
        {
            txtBrojRacuna.Text = DateTime.Now.Date.ToString("yyyyMMdd") + "/" + GetSifraRacuna().ToString();
            txtVrijeme.Text = DateTime.Now.ToString();
            txtOTvrtci.Text = "Naziv: ZAGREBAČKI HOLDING d.o.o." + Environment.NewLine + Environment.NewLine + "Sjedište: Avenija Dubrovnik 15, 10020 Zagreb" + Environment.NewLine + Environment.NewLine + "OIB: 85584865987-024";
        }
        /// <summary>
        /// Dohvaća broj računa u bazi te vraća taj broj uvećan za 1
        /// </summary>
        /// <returns></returns>
        public int GetSifraRacuna()
        {
            using (var db = new ProdajaKarataEntities())
            {
                int sifra = (from s in db.Racuns select s).Count() + 1;
                return sifra;
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            FrmNovaStavka novaStavka = new FrmNovaStavka();
            novaStavka.Show();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {

        }

        private void btnIspisi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
