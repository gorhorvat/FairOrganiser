using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvidencijaSudionika
{
    public partial class FrmIzdanaAkreditacija : Form
    {
        private Image qrCode;
        private Sudionik odabraniSudionik;
        private string akreditacija;
        public FrmIzdanaAkreditacija(Image QRCode, Sudionik OdabraniSudionik, string Akreditacija)
        {
            qrCode = QRCode;
            odabraniSudionik = OdabraniSudionik;
            akreditacija = Akreditacija;
            InitializeComponent();
        }
        /// <summary>
        /// Prikaz izdane akreditacije.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIzdanaAkreditacija_Load(object sender, EventArgs e)
        {
            txtImePrezime.Text = odabraniSudionik.ime + " " + odabraniSudionik.prezime;
            txtMedijskaKuca.Text = odabraniSudionik.medijskaKuca;
            txtDogadaj.Text = odabraniSudionik.dogadaj;
            txtAkreditacija.Text = akreditacija;
            pbQRCode.Image = qrCode;
        }
    }
}
