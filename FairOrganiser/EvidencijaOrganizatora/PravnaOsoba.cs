using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaOrganizatora
{
    class PravnaOsoba : Organizator
    {
        public string naziv { get; set; }
        public string maticniBroj { get; set; }
        public string sifraDjelatnosti { get; set; }

        public PravnaOsoba(string oib, string adresa, string email, string telefon, string naziv, string maticniBroj, string sifraDjelatnosti)
        {
            this.oib = oib;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
            this.naziv = naziv;
            this.maticniBroj = maticniBroj;
            this.sifraDjelatnosti = sifraDjelatnosti;
        }
    }
}
