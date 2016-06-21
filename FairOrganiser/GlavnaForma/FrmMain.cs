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
            EvidencijaOrganizatora.FrmEvidencija organizator = new EvidencijaOrganizatora.FrmEvidencija();
            organizator.Show();
        }

        private void btnSudionici_Click(object sender, EventArgs e)
        {
            EvidencijaSudionika.FrmEvidencija sudionik = new EvidencijaSudionika.FrmEvidencija();
            sudionik.Show();
        }

        private void btnIzvjesce_Click(object sender, EventArgs e)
        {
            FrmIzvjesca izvjesca = new FrmIzvjesca();
            izvjesca.Show();
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
            FrmUsluga usluga = new FrmUsluga();
            usluga.Show();
        }

        private void btnDogadaj_Click(object sender, EventArgs e)
        {
            LogikaDogadaj logikaD = new LogikaDogadaj();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
