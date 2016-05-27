using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class FizickaOsoba : Organizator
    {
        public string ime { get; set; }
        public string prezime { get; set; }

        public FizickaOsoba(string oib, string adresa, string email, string telefon, string ime, string prezime)
        {
            this.oib = oib;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
