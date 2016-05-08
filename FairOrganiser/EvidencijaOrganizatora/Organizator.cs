using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaOrganizatora
{
    abstract class Organizator
    {
        public string oib { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
    }

}
