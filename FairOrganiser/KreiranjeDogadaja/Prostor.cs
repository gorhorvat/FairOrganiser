using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreiranjeDogadaja
{
    class Prostor
    {
        float sirina { get; set; }
        float visina { get; set; }
        float duljina { get; set; }
        bool dostupnost;
        Bitmap slika;
        VizualniPrikaz prikaz { get; set; }
        List<ProdajaKarata.Usluga> usluga { get; set; }

        public Prostor(float sirina, float visina, float duljina, bool dostupnost, Bitmap slika)
        {
            this.sirina = sirina;
            this.visina = visina;
            this.duljina = duljina;
            this.dostupnost = dostupnost;
            this.slika = slika;
        }

        public bool IzmjeniUsluge(List<ProdajaKarata.Usluga> usluga)
        {
            //kod
            return false;
        }

    }

   

}
