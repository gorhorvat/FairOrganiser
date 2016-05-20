using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Usluga
    {
        private string naziv { get; set; }
        private string tip { get; set; }
        private string napomena { get; set; }

        public Usluga(string naziv, string tip, string napomena)
        {
            this.naziv = naziv;
            this.tip = tip;
            this.napomena = napomena;
        }
    }
}
