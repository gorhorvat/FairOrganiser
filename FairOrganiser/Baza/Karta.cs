using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Karta
    {
        private DateTime _datum;
        private TipKarte _tipKarte;
        private Dogadaj _dogadaj;

        public DateTime Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }

        public TipKarte TipKarte
        {
            get { return _tipKarte; }
            set { _tipKarte = value; }
        }

        public Dogadaj Dogadaj
        {
            get { return _dogadaj; }
            set { _dogadaj = value; }
        }

        //u konstruktor staviti TipKarte tipKarte, Dogadaj dogadaj
        public Karta(DateTime datum)
        {
            _datum = datum;
            //_tipKarte = tipKarte;
            //_dogadaj = dogadaj;
        }

        public void prodajKartu()
        {

        }
    }
}
