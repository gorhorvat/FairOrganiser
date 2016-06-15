using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public class LogikaPK
    {
        /// <summary>
        /// Metoda za prikazivanje liste cjenika na formi FrmCjenik.
        /// </summary>
        public BindingList<CjenikDogadaja> PrikaziCjenike()
        {
            BindingList<CjenikDogadaja> popisCjenika = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisCjenika = new BindingList<CjenikDogadaja>(db.CjenikDogadajas.ToList());
                return popisCjenika;
            }
        }

        /// <summary>
        /// Metoda za dodavanje cjenika na formi FrmCjenik.
        /// </summary>
        /// <param name="VrijediOd"></param>
        /// <param name="VrijediDo"></param>
        public void DodajCjenik(DateTime VrijediOd, DateTime VrijediDo)
        {
            using (var db = new ProdajaKarataEntities())
            {
                CjenikDogadaja noviCjenik = new CjenikDogadaja
                {
                    vrijediOd = VrijediOd,
                    vrijediDo = VrijediDo
                };
                db.CjenikDogadajas.Add(noviCjenik);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Metoda za brisanje cjenika na formi FrmCjenik
        /// </summary>
        /// <param name="CjenikID"></param>
        public void ObrisiCjenik(int CjenikID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                CjenikDogadaja brisiCjenik = (from c in db.CjenikDogadajas
                                              where c.id == CjenikID
                                              select c).First();
                if (brisiCjenik != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.CjenikDogadajas.Remove(brisiCjenik);
                        db.SaveChanges();
                    }
                }
            }
        }

        /// <summary>
        /// Dohvaća broj karata u bazi uvećan za 1
        /// </summary>
        public int GetSifraKarte()
        {
            using (var db = new ProdajaKarataEntities())
            {
                int sifra = (from s in db.Kartas select s).Count() + 1;
                return sifra;
            }
        }

        /// <summary>
        /// Dohvaća cijenu jedne karte sa i izračunava cijenu s popustom.
        /// </summary>
        /// <param name="cijena"></param>
        /// <param name="popust"></param>
        /// <returns></returns>
        public float GetCijenaKarte(float cijena, float popust)
        {
            float cijenaKarte = (float)cijena - ((float)cijena * ((float)popust / 100));
            return cijenaKarte;
        }

        /// <summary>
        /// Dohvaća listu svih događaja u kontekstu, te ih prikazuje u DataGridView-u na formi FrmKarta.
        /// </summary>
        public BindingList<Dogadaj> PrikaziDogadaje()
        {
            BindingList<Dogadaj> popisDogadaja = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisDogadaja = new BindingList<Dogadaj>(db.Dogadajs.ToList());
                return popisDogadaja;
            }
        }

        /// <summary>
        /// Dohvaća listu svih tipova karata u kontekstu, te ih prikazuje u DataGridView-u na formi FrmKarta.
        /// </summary>
        public BindingList<TipKarte> PrikaziTipove()
        {
            BindingList<TipKarte> popisTipova = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisTipova = new BindingList<TipKarte>(db.TipKartes.ToList());
                return popisTipova;
            }
        }

        /// <summary>
        /// Sprema instancu karte u bazu zajedno sa vanjskim ključevima.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SpremiKartu(DateTime Datum, int dogadajID, int cjenikID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                Karta novaKarta = new Karta
                {
                    datum = Datum,
                    Dogadajid = dogadajID,
                    Cjenikid = cjenikID
                };
                db.Kartas.Add(novaKarta);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Dohvaća listu svih usluga u kontekstu, te ih prikazuje u ComboBox-u na formi FrmNovaStavka.
        /// </summary>
        public BindingList<Usluga> PrikaziUsluge()
        {
            BindingList<Usluga> popisUsluga = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisUsluga = new BindingList<Usluga>(db.Uslugas.ToList());
                return popisUsluga;
            }
        }

        /// <summary>
        /// Metoda za dodavanje usluge na formi FrmNovaUsluga.
        /// </summary>
        /// <param name="Naziv"></param>
        /// <param name="Tip"></param>
        /// <param name="Napomena"></param>
        /// <param name="Cijena"></param>
        public void DodajNovuUslugu(string Naziv, string Tip, string Napomena, float Cijena)
        {
            using (var db = new ProdajaKarataEntities())
            {
                Usluga novaUsluga = new Usluga
                {
                    naziv = Naziv,
                    tip = Tip,
                    napomena = Napomena,
                    cijenaUsluge = Cijena
                };
                db.Uslugas.Add(novaUsluga);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Briše selektirani tip karte iz cjenika na formi FrmPregledCjenika.
        /// </summary>
        /// <param name="TipID"></param>
        public void ObrisiTip(int TipID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                TipKarte brisiTip = (from t in db.TipKartes
                                     where t.id == TipID
                                     select t).First();

                if (brisiTip != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.TipKartes.Remove(brisiTip);
                        db.SaveChanges();
                    }
                }
            }
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
        /// Dohvaća uslugu sa odabranim ID-om na formi FrmUsluga i briše je iz baze
        /// </summary>
        /// <param name="UslugaID"></param>
        public void ObrisiUslugu(int UslugaID)
        {
            using (var db = new ProdajaKarataEntities())
            {
                Usluga brisiUslugu = (from b in db.Uslugas
                                      where b.id == UslugaID
                                      select b).First();
                if (brisiUslugu != null)
                {
                    if (MessageBox.Show("Da li ste sigurni?", "Upozorenje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.Uslugas.Remove(brisiUslugu);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
