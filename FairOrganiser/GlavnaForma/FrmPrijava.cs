using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlavnaForma
{
    public partial class FrmPrijava : Form
    {
        public Zaposlenik aktivniZaposlenik;
        string username;
        public FrmPrijava()
        {
            InitializeComponent();
        }
        PrijavaEntities podaci = new PrijavaEntities();
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            /*
            this.Hide();
            FrmMain glavna = new FrmMain();
            glavna.Show();
            */
            bool nadjen = false;
            foreach (var Zaposlenik in podaci.Zaposleniks)
            {
                if(Zaposlenik.username.Replace(" ", "")  == txtKorisnickoIme.Text && Zaposlenik.password.Replace(" ", "") == txtLozinka.Text)
                {
                    nadjen = true;
                    aktivniZaposlenik = Zaposlenik;
                    username = Zaposlenik.username;
                    this.Hide();
                    FrmMain glavna = new FrmMain(username);
                    glavna.Show();
                }
            }
            if(nadjen == false)
            {
                    MessageBox.Show("Molimo Vas provjerite vaše korisničko ime i lozinku.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void FrmPrijava_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
