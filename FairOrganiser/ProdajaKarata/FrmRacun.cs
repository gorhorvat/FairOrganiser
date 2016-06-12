using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmRacun : Form
    {
        public FrmRacun()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Dakle, forma Račun sadržava operatera - zaposlenik, naziv kupca - organizator, dgvStavkeRačuna - lista usluga (samo one označene kod odabira prostora i svih usluga za događaj)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRacun_Load(object sender, EventArgs e)
        {
            txtBrojRacuna.Text = DateTime.Now.Date.ToString("yyyyMMdd") + "/" + GetSifraRacuna().ToString();
            txtVrijeme.Text = DateTime.Now.ToString();
            txtOTvrtci.Text = "Naziv: ZAGREBAČKI HOLDING d.o.o." + Environment.NewLine + Environment.NewLine + "Sjedište: Avenija Dubrovnik 15, 10020 Zagreb" + Environment.NewLine + Environment.NewLine + "OIB: 85584865987-024";
        }
        /// <summary>
        /// Dohvaća broj računa u bazi te vraća taj broj uvećan za 1
        /// </summary>
        /// <returns></returns>
        public int GetSifraRacuna()
        {
            using (var db = new ProdajaKarataEntities())
            {
                int sifra = (from s in db.Racuns select s).Count() + 1;
                return sifra;
            }
        }
        /// <summary>
        /// Funkcija kojom se račun pretvara u pdf i sprema gdje korisnik odredi.
        /// </summary>
        public void FormToPdf()
        {
            string nazivDatoteke = DateTime.Now.Date.ToString("yyyyMMdd") + "_" + GetSifraRacuna().ToString();

            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = nazivDatoteke;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                string savePath = Path.GetDirectoryName(sf.FileName);

                var frm = Form.ActiveForm;
                using (var forma = new Bitmap(frm.Width, frm.Height))
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    btnDodajStavku.Hide();
                    btnIspisi.Hide();
                    btnObrisiStavku.Hide();

                    frm.DrawToBitmap(forma, new System.Drawing.Rectangle(0, 0, forma.Width, forma.Height));
                    forma.Save(savePath + "\\" + nazivDatoteke + ".png");

                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    btnDodajStavku.Show();
                    btnIspisi.Show();
                    btnObrisiStavku.Show();

                    Document document = new Document();
                    document.SetPageSize(PageSize.A4.Rotate());
                    PdfWriter.GetInstance(document, new FileStream(savePath + "\\" + nazivDatoteke + ".pdf", FileMode.Create));
                    document.Open();
                    iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance(forma, System.Drawing.Imaging.ImageFormat.Png);

                    document.Add(pic);
                    forma.Dispose();
                    File.Delete(savePath + "\\" + nazivDatoteke + ".png");
                    document.Close();
                }
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            FrmNovaStavka novaStavka = new FrmNovaStavka();
            novaStavka.Show();
        }

        private void btnObrisiStavku_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Klikom na tipku "Ispisi" račun se sprema u bazu te se sprema gdje korisnik odredi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIspisi_Click(object sender, EventArgs e)
        {
            FormToPdf();
            Close();
        }
    }
}
