using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QRCodeGenerator;

namespace EvidencijaSudionika
{
    public partial class FrmAkreditacija : Form
    {
        private Sudionik odabranisudionik;
        private int sudionikID;
        public FrmAkreditacija(Sudionik OdabraniSudionik, int SudionikID)
        {
            odabranisudionik = OdabraniSudionik;
            sudionikID = SudionikID;
            InitializeComponent();
        }
        /// <summary>
        /// Prikaz podataka o odabranom sudioniku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAkreditacija_Load(object sender, EventArgs e)
        {
            txtIme.Text = odabranisudionik.ime;
            txtPrezime.Text = odabranisudionik.prezime;
            txtMedKuca.Text = odabranisudionik.medijskaKuca;
            txtTelefon.Text = odabranisudionik.telefon;
            txtEmail.Text = odabranisudionik.email;
            txtDogadaj.Text = odabranisudionik.dogadaj;
            PrikaziAkreditacije();

        }
        /// <summary>
        /// Prikaz liste tipova akreditacija u combobox-u.
        /// </summary>
        private void PrikaziAkreditacije()
        {
            List<string> tipoviAkreditacije = new List<string>() { "Novinar", "Izvođač", "Fotograf", "Tehničar", "VIP", "Organizator" };
            tipAkreditacijeBindingSource.DataSource = tipoviAkreditacije;
        }
        /// <summary>
        /// Proslijeđivanje svih podataka formi za prikaz izdane akreditacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            FrmIzdanaAkreditacija izdanaAkredicatija = new FrmIzdanaAkreditacija(pbQR.Image, odabranisudionik, cmbAkreditacija.SelectedValue.ToString());
            izdanaAkredicatija.ShowDialog();
            dodajAkreditaciju();
            this.Close();         
            
        }
        /// <summary>
        /// Generiranje QR koda za prikazane podatke te odabrane vrste akreditacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAkreditacija_SelectedValueChanged(object sender, EventArgs e)
        {
            QRCodeGenerator.QRCode dlltest = new QRCode();
            pbQR.Image = dlltest.generirajQR(odabranisudionik.ime, odabranisudionik.prezime, odabranisudionik.dogadaj, cmbAkreditacija.Text);
           
        }

        private void dodajAkreditaciju()
        {
            using(var db = new EvidencijaSudionikaEntities())
            {
                Sudionik azuriraniSudionik = (from s in db.Sudioniks
                                              where s.id == sudionikID
                                              select s).First();
                azuriraniSudionik.akreditacija = cmbAkreditacija.SelectedValue.ToString() ;
                db.SaveChanges();
            }
        }
    }
}

