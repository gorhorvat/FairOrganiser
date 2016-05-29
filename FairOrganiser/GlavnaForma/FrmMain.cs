using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //FrmOrganizator organizator = new FrmOrganizator();
            //organizator.Show();
        }

        private void btnSudionici_Click(object sender, EventArgs e)
        {
            //FrmSudionik sudionik = new FrmSudionik();
            //sudionik.Show();
        }

        private void btnIzvjesce_Click(object sender, EventArgs e)
        {
            LogikaGF.StartIzvjesce();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            LogikaGF.StartRacun();
        }

        private void btnKarta_Click(object sender, EventArgs e)
        {
            LogikaGF.StartKarta();
        }

        private void btnPopusti_Click(object sender, EventArgs e)
        {
            LogikaGF.StartCjenik();
        }

        private void btnUsluge_Click(object sender, EventArgs e)
        {
            LogikaGF.StartUsluga();
        }

        private void btnDogadaj_Click(object sender, EventArgs e)
        {
            //kreiranje dogadaja logika
            LogikaGF.StartDogadaj();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FrmPrijava prijava = new FrmPrijava();
            prijava.Show();
            Close();
        }
    }
}
