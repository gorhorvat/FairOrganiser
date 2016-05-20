using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Cjenik
    {
        private DateTime vrijediOd { get; set; }
        private DateTime vrijediDo { get; set; }

        public Cjenik(DateTime vrijediOd, DateTime vrijediDo)
        {
            this.vrijediOd = vrijediOd;
            this.vrijediDo = vrijediDo;
        }

        public void obrisiTip()
        {

        }
    }
}
