using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizualniPrikazProstora
{
    class VizualniPrikaz
    {

        string ime { get; set; }
        Bitmap slika { get; set; }

        public VizualniPrikaz(string ime)
        {
            this.ime = ime;
        }

        /*
        Generiranje prikaza zauzetih prostora za dogadaj
        */
       public bool generirajPrikaz(Dogadaj dogadaj)
        {
            //kod
            return false;
        }


        /*
        Generiranje prikaza rasporeda opreme za prostor
        */
        public bool generirajPrikaz(Prostor prostor)
        {
            //kod
            return false;
        }

    }
}
