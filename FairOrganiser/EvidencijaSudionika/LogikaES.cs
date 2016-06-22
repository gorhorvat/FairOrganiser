using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCodeGenerator;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace EvidencijaSudionika
{
    public class LogikaES
    {
        List<Sudionik> akreditiraniSudionici;
        private Image QRcode;
        /// <summary>
        /// Sprema akreditacije na odabrano mjesto.
        /// </summary>
        public void izvozAkreditacija()
        {
            string nazivDatoteke;
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                string savePath = Path.GetDirectoryName(sf.FileName);
                AkreditiraniSudionici();
                QRCodeGenerator.QRCode generator = new QRCode();
                foreach (var sudionik in akreditiraniSudionici)
                {
                    nazivDatoteke = sudionik.ime + sudionik.prezime;
                    QRcode = generator.generirajQR(sudionik.ime, sudionik.prezime, sudionik.dogadaj, sudionik.akreditacija);
                    FrmIzdanaAkreditacija akreditacija = new FrmIzdanaAkreditacija(QRcode, sudionik, sudionik.akreditacija);
                    akreditacija.Show();
                    var frm = Form.ActiveForm;
                    using (var bmp = new Bitmap(frm.Width, frm.Height))
                    {
                        frm.FormBorderStyle = FormBorderStyle.None;
                        frm.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                        bmp.Save(savePath+ "\\" + nazivDatoteke + ".jpg");
                        akreditacija.Close();
                    }
                }
                MessageBox.Show("Akreditacije su uspješno izvezene.");
            }
                
        }

        /// <summary>
        /// Dohvaća akreditirane sudionike iz baze.
        /// </summary>
        private void AkreditiraniSudionici()
        {
            akreditiraniSudionici = null;
            using (var db = new EvidencijaSudionikaEntities())
            {
                var akreditiraniSudionik = from s in db.Sudioniks
                                           where s.akreditacija != null
                                           select s;
                akreditiraniSudionici = akreditiraniSudionik.ToList();
            }
        }




    }
}
