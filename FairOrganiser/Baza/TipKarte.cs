using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class TipKarte
    {
        int _iznosPopusta;
        string _naziv;

        public int IznosPopusta
        {
            get { return _iznosPopusta; }
            set { _iznosPopusta = value; }
        }

        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public TipKarte(DbDataReader dbReader)
        {
            _iznosPopusta = int.Parse(dbReader["iznosPopusta"].ToString());
            _naziv = dbReader["naziv"].ToString();
        }
    }
}
