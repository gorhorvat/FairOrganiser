using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvidencijaOrganizatora
{
    public partial class FrmNoviOrganizator : Form
    {
        private Organizator organizatorZaIzmjenu;
        /// <summary>
        /// Konstruktor forme za izmjenu postojećeg organizatora.
        /// </summary>
        /// <param name="organizator"></param>
        public FrmNoviOrganizator(Organizator organizator)
        {
            InitializeComponent();
            organizatorZaIzmjenu = organizator;
        }
        public FrmNoviOrganizator()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Promjena kontrola za unos ovisno o odabranom tipu organizatora.
        /// </summary>
        private void promjeniFormu()
        {
            if (cmbTip.Text == "Fizicka osoba")
            {
                label1.Text = "Ime i prezime: ";
                txtPrezime.Show();
                txtIme.Width = 100;
            }
            else
            {
                label1.Text = "Naziv: ";
                txtPrezime.Hide();
                txtIme.Width = 207;
            }
        }

        private void FrmNoviOrganizator_Load(object sender, EventArgs e)
        {
            PrikaziTipove();
            promjeniFormu();
            if (organizatorZaIzmjenu != null)
            {
                if(organizatorZaIzmjenu.TipOrganizatoraid == 1)
                {
                    cmbTip.Text = "Fizicka osoba";
                    promjeniFormu();
                    string[] polje = organizatorZaIzmjenu.naziv.Split(' ');
                    txtIme.Text = polje[0].ToString();
                    txtPrezime.Text = polje[1].ToString();
                }
                else
                {
                    cmbTip.Text = "Pravna osoba";
                    promjeniFormu();
                    txtIme.Text = organizatorZaIzmjenu.naziv;
                }
                mtxtOIB.Text = organizatorZaIzmjenu.oib;
                txtAdresa.Text = organizatorZaIzmjenu.adresa;
                txtEmail.Text = organizatorZaIzmjenu.email;
                mtxtTelefon.Text = organizatorZaIzmjenu.brojTelefona;
            }
        }
        /// <summary>
        /// Dohvacanje tipova organizatora iz baze.
        /// </summary>
        private void PrikaziTipove()
        {
            BindingList<TipOrganizatora> listaTipova = null;
            using (var db = new evidencijaOrganizatoraEntities())
            {
                listaTipova = new BindingList<TipOrganizatora>(db.TipOrganizatoras.ToList());
            }
            tipOrganizatoraBindingSource.DataSource = listaTipova;
        }
        /// <summary>
        /// Prikaz drugačijih kontrola za unos podataka o organizatoru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            promjeniFormu();
        }
        /// <summary>
        /// Dodavanje organizatora u bazu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajOrg_Click(object sender, EventArgs e)
        {
            using (var db = new evidencijaOrganizatoraEntities())
            {
                if (organizatorZaIzmjenu == null)
                {
                    Organizator noviOrganizator = new Organizator();
                    {

                        if (cmbTip.Text == "Fizicka osoba")
                        {
                            noviOrganizator.naziv = txtIme.Text + " " + txtPrezime.Text;
                            noviOrganizator.TipOrganizatoraid = 1;
                        }
                        else
                        {
                            noviOrganizator.naziv = txtIme.Text;
                            noviOrganizator.TipOrganizatoraid = 2;
                        }
                        noviOrganizator.oib = mtxtOIB.Text;
                        noviOrganizator.adresa = txtAdresa.Text;
                        noviOrganizator.email = txtEmail.Text;
                        noviOrganizator.brojTelefona = mtxtTelefon.Text;
                    };
                    db.Organizators.Add(noviOrganizator);
                    db.SaveChanges();
                }
                else
                {
                    Organizator azuriraniOrganizator = (from s in db.Organizators
                                                  where s.id == organizatorZaIzmjenu.id
                                                  select s).First();
                    if(azuriraniOrganizator.TipOrganizatoraid == 1)
                    {
                        azuriraniOrganizator.naziv = txtIme.Text + " " + txtPrezime.Text;
                    }
                    else
                    {
                        azuriraniOrganizator.naziv = txtIme.Text;
                    }
                    azuriraniOrganizator.oib = mtxtOIB.Text;
                    azuriraniOrganizator.adresa = txtAdresa.Text;
                    azuriraniOrganizator.email = txtEmail.Text;
                    azuriraniOrganizator.brojTelefona = mtxtTelefon.Text;

                    db.SaveChanges();
                }
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
