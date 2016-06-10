using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.Text;
using ProdajaKarata;
using EvidencijaOrganizatora;
using EvidencijaSudionika;
using KreiranjeDogadaja;
using GeneriranjeIzvjesca;

namespace GlavnaForma
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnPopusti_Click(object sender, EventArgs e)
        {
            FrmCjenik cjenik = new FrmCjenik();
            cjenik.Show();
        }

        private void btnOrganizatori_Click(object sender, EventArgs e)
        {
            FrmOrganizator organizator = new FrmOrganizator();
            organizator.Show();
        }

        private void btnSudionici_Click(object sender, EventArgs e)
        {
            FrmSudionik sudionik = new FrmSudionik();
            sudionik.Show();
        }

        private void btnIzvjesce_Click(object sender, EventArgs e)
        {
            FrmIzvjesce izvjesce = new FrmIzvjesce();
            izvjesce.Show();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            FrmRacun racun = new FrmRacun();
            racun.Show();
        }

        private void btnKarta_Click(object sender, EventArgs e)
        {
            FrmKarta karta = new FrmKarta();
            karta.Show();
        }

        private void btnUsluge_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDogadaj_Click(object sender, EventArgs e)
        {
            FrmDogadaj dogadaj = new FrmDogadaj();
            dogadaj.Show();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
