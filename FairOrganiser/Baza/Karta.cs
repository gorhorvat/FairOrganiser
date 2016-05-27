using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Karta
    {
        private int brojKarte { get; set; }
        private DateTime datum { get; set; }
        private TipKarte tipKarte { get; set; }
        private Dogadaj dogadaj { get; set; }

        public Karta(int broj, DateTime datum, TipKarte tipKarte, Dogadaj dogadaj)
        {
            this.brojKarte = broj;
            this.datum = datum;
            this.tipKarte = tipKarte;
            this.dogadaj = dogadaj;
        }

        public void prodajKartu()
        {

        }
    }
}
