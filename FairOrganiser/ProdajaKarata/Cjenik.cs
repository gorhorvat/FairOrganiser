using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaKarata
{
    public class Cjenik
    {
        private DateTime vrijediOd { get; set; }
        private DateTime vrijediDo { get; set; }

        public Cjenik(List<TipKarte> tipovi, DateTime vrijediOd, DateTime vrijediDo)
        {
            this.vrijediOd = vrijediOd;
            this.vrijediDo = vrijediDo;
        }

        public void obrisiTip()
        {

        }
    }
}
