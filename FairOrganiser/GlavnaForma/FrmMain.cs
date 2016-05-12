using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdajaKarata;
using GeneriranjeIzvjesca;
using KreiranjeDogadaja;
using EvidencijaOrganizatora;
using EvidencijaSudionika;

namespace GlavnaForma
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            
        }

        private void btnOrganizatori_Click(object sender, EventArgs e)
        {
            FrmOrganizator organizator = new FrmOrganizator();
            organizator.ShowDialog();
        }

        private void btnSudionici_Click(object sender, EventArgs e)
        {
            FrmSudionik sudionik = new FrmSudionik();
            sudionik.ShowDialog();
        }

        private void btnCjenik_Click(object sender, EventArgs e)
        {
            FrmCjenik cjenik = new FrmCjenik();
            cjenik.ShowDialog();
        }

        private void btnIzvjesce_Click(object sender, EventArgs e)
        {
            FrmIzvjesce izvjesce = new FrmIzvjesce();
            izvjesce.ShowDialog();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            FrmRacun racun = new FrmRacun();
            racun.ShowDialog();
        }

        private void btnKarta_Click(object sender, EventArgs e)
        {
            FrmKarta karta = new FrmKarta();
            karta.Show();
        }

        private void btnDogadaj_Click(object sender, EventArgs e)
        {
            FrmDogadaj dogadaj = new FrmDogadaj();
            dogadaj.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava prijava = new FrmPrijava();
            prijava.ShowDialog();
        }
    }
}
