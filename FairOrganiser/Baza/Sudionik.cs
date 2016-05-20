using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Sudionik
    {
        private string ime { get; set; }
        private string prezime { get; set; }

        private List<Akreditacija> listaAkreditacija = new List<Akreditacija>();


        public Sudionik(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

    }
}
