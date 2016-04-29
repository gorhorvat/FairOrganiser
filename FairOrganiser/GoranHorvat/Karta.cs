using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoranHorvat
{
    class Karta
    {
        private int brojKarte { get; set; }
        private DateTime datum { get; set; }
        private float cijena { get; set; }
        private TipKarte tipKarte { get; set; }
        //private Dogadaj dogadaj { get; set; }

        public Karta(int broj, DateTime datum, float cijena, TipKarte tipKarte) //dodati događaj kad fran kreira događaj
        {
            this.brojKarte = broj;
            this.datum = datum;
            this.cijena = cijena;
            this.tipKarte = tipKarte;
        }

        public void prodajKartu()
        {

        }
    }
}
