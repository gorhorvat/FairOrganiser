using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Cjenik
    {
        DateTime _vrijediOd;
        DateTime _vrijediDo;

        public DateTime VrijediOd
        {
            get { return _vrijediOd; }
            set { _vrijediOd = value; }
        }

        public DateTime VrijediDo
        {
            get { return _vrijediDo; }
            set { _vrijediDo = value; }
        }

        public Cjenik(DateTime vrijediOd, DateTime vrijediDo)
        {
            _vrijediOd = vrijediOd;
            _vrijediDo = vrijediDo;
        }

        public Cjenik(DbDataReader dbReader)
        {
            DateTime.TryParse(dbReader["vrijediOd"].ToString(), out _vrijediOd);
            DateTime.TryParse(dbReader["vrijediDo"].ToString(), out _vrijediDo);
        }

        public void obrisiTip()
        {

        }
    }
}
