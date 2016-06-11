using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

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

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {

            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(odabranisudionik.ime + odabranisudionik.prezime + odabranisudionik.dogadaj);
            pbQR.Image = qrcode as Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            MessageBox.Show(decoder.decode(new QRCodeBitmapImage(pbQR.Image as Bitmap)));
        }
    }
}

