using System;
using System.Windows.Forms;
using ProdajaKarata;
using EvidencijaOrganizatora;
using EvidencijaSudionika;
using KreiranjeDogadaja;
using GeneriranjeIzvjesca;

namespace GlavnaForma
{
    public partial class FrmMain : Form
    {
        public bool provjera = false;
        public FrmMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Zatvara formu dijete ukoliko postoji.
        /// </summary>
        private void closeChildForm()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }
        private void popisOrganizatoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForm();
            FrmEvidencijaOrg formaDjete = new FrmEvidencijaOrg();
            formaDjete.MdiParent = this;
            formaDjete.WindowState = FormWindowState.Maximized;
            formaDjete.Show();
        }

        private void dodajOrganizatoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNoviOrganizator noviOrganizator = new FrmNoviOrganizator();
            noviOrganizator.ShowDialog();
        }

        private void dodajSudionikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNoviSudionik noviSudionik = new FrmNoviSudionik();
            noviSudionik.ShowDialog();
        }

        private void popisSudionikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForm();
            FrmEvidencija popisSudionika = new FrmEvidencija();
            popisSudionika.MdiParent = this;
            popisSudionika.WindowState = FormWindowState.Maximized;
            popisSudionika.Show();
            
        }

        private void brojPosjetiteljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzvjesceBrojPosjetitelja brojPosjetitelja = new FrmIzvjesceBrojPosjetitelja();
            brojPosjetitelja.ShowDialog();
        }

        private void prodaneUslugeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzvjesceProdaneUsluge prodaneUsluge = new FrmIzvjesceProdaneUsluge();
            prodaneUsluge.ShowDialog();
        }

        private void popunjenostKapacitetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzvjescePopunjenostKapaciteta kapaciteti = new FrmIzvjescePopunjenostKapaciteta();
            kapaciteti.ShowDialog();
        }

        private void organiziraniDogađajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzvjesceOrganiziraniDogadaji dogadaji = new FrmIzvjesceOrganiziraniDogadaji();
            dogadaji.ShowDialog();
        }

        private void dodajDogađajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForm();
            LogikaDogadaj log = new LogikaDogadaj();
            FrmDogadaj dogadaj = new FrmDogadaj(log);
            log.AddForm(dogadaj);
            dogadaj.MdiParent = this;
            dogadaj.WindowState = FormWindowState.Maximized;
            dogadaj.Show();
        }

        private void prikazRačunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRacun racun = new FrmRacun();
            racun.Show();
        }

        private void kartaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmKarta karta = new FrmKarta();
            karta.Show();
        }

        private void popustiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForm();
            FrmCjenik cjenik = new FrmCjenik();
            cjenik.MdiParent = this;
            cjenik.WindowState = FormWindowState.Maximized;
            cjenik.Show();
        }

        private void prikazUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closeChildForm();
            FrmUsluga usluga = new FrmUsluga();
            usluga.MdiParent = this;
            usluga.WindowState = FormWindowState.Maximized;
            usluga.Show();
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            if (provjera == false)
            {
                FrmPrijava novaPrijava = new FrmPrijava();
                novaPrijava.Show();
            }
            
        }
        private void ispisAkreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogikaES log = new LogikaES();
            log.izvozAkreditacija();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            provjera = true;
            FrmPrijava novaPrijava = new FrmPrijava();
            novaPrijava.Show();
        }
    }
}
