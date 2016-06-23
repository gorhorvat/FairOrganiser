using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmPrikazRacuna : Form
    {
        LogikaPK logika = new LogikaPK();

        private Racun odabraniRacun;
        private int racunID;
        private string nazivKupca;
        private string aktivniKorisnik;

        public FrmPrikazRacuna(Racun OdabraniRacun, int RacunID, string NazivKupca, string AktivniKorisnik)
        {
            aktivniKorisnik = AktivniKorisnik;
            odabraniRacun = OdabraniRacun;
            racunID = RacunID;
            nazivKupca = NazivKupca;
            InitializeComponent();
        }

        /// <summary>
        /// Dakle, forma Račun sadržava operatera - zaposlenik, naziv kupca - organizator, dgvStavkeRačuna - lista usluga (samo one označene kod odabira prostora i svih usluga za događaj)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrikazRacuna_Load(object sender, EventArgs e)
        {
            PrikaziStavkeRacuna(racunID);
            txtOperater.Text = aktivniKorisnik;

            float total = 0;
            for (int i = 0; i < dgvListaStavki.Rows.Count; i++)
            {
                total += Convert.ToSingle(dgvListaStavki.Rows[i].Cells["Cijena_usluge"].Value);
                txtUkupno.Text = total.ToString("N", CultureInfo.InvariantCulture);
            }

            txtNazivKupca.Text = nazivKupca;
            txtBrojRacuna.Text = DateTime.Now.Date.ToString("yyyyMMdd") + "/" + logika.GetSifraRacuna().ToString();
            txtVrijeme.Text = DateTime.Now.ToString();
            txtOTvrtci.Text = "Naziv: ZAGREBAČKI HOLDING d.o.o." + Environment.NewLine + Environment.NewLine + "Sjedište: Avenija Dubrovnik 15, 10020 Zagreb" + Environment.NewLine + Environment.NewLine + "OIB: 85584865987-024";
        }

        /// <summary>
        /// Dohvaća listu svih stavki za aktualni račun, te ih prikazuje u DataGridView-u.
        /// </summary>
        public void PrikaziStavkeRacuna(int RacunID)
        {
            using (var context = new ProdajaKarataEntities())
            {
                Racun r = (from rac in context.Racuns where rac.id == RacunID select rac).FirstOrDefault();
                //var prikazStavki = context.Uslugas.SqlQuery("select Usluga.naziv, Usluga.tip, Usluga.napomena, Usluga.cijenaUsluge from Usluga join tse_usl_rac on Usluga.id = tse_usl_rac.Uslugaid join Racun on tse_usl_rac.Racunid = Racun.id where Racun.id = @RacunID;", new SqlParameter ("@RacunID", RacunID)).ToList();

                context.Racuns.Add(r);
                context.Racuns.Attach(r);

                var stavke = r.Uslugas.ToList();
                context.SaveChanges();

                dgvListaStavki.AutoGenerateColumns = true;
                dgvListaStavki.DataSource = stavke.Select(s => new { Naziv_usluge = s.naziv, Tip = s.tip, Napomena = s.napomena, Cijena_usluge = s.cijenaUsluge }).ToList();
                dgvListaStavki.Refresh();
            }
        }

        /// <summary>
        /// Funkcija kojom se račun pretvara u pdf i sprema gdje korisnik odredi.
        /// </summary>
        public void FormToPdf()
        {
            string nazivDatoteke = DateTime.Now.Date.ToString("yyyyMMdd") + "_" + logika.GetSifraRacuna().ToString();

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
            FrmNovaStavka novaStavka = new FrmNovaStavka(racunID);
            novaStavka.ShowDialog();
        }

        /// <summary>
        /// Klikom na tipku "Obriši" stavka računa se briše iz baze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
