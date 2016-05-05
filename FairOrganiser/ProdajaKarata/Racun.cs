using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaKarata
{
    public class Racun
    {
        public List<Usluga> listaStavki = new List<Usluga>();

        private int brojRacuna { get; set; }
        private string operater { get; set; }
        private DateTime vrijeme { get; set; }
        private string nazivTvrtke { get; set; }
        private string sjediste { get; set; }
        private string oib { get; set; }
        private float ukupno { get; set; }
        private string nazivKupca { get; set; }

        public Racun(List<Usluga> stavke, int broj, string operater, DateTime vrijeme, string tvrtka, string sjediste, string oib, float ukupno, string kupac)
        {
            this.listaStavki = stavke;
            this.brojRacuna = broj;
            this.operater = operater;
            this.vrijeme = vrijeme;
            this.nazivTvrtke = tvrtka;
            this.sjediste = sjediste;
            this.oib = oib;
            this.ukupno = ukupno;
            this.nazivKupca = kupac;
        }

        public void dodajStavku()
        {

        }

        public void obrisiStavku()
        {

        }

        public void izmjeniRacun()
        {

        }

        public void ispisiRacun()
        {

        }
    }
}
