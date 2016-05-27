using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracts;

namespace Baza
{
    public class Prostor 
    {
        private float _sirina;
        private float _visina;
        private float _duljina;
        
        VizualniPrikaz prikaz { get; set; }
        List<Usluga> usluga { get; set; }

        public float Sirina
        {
            get { return _sirina; }
            set { _sirina = value; }
        }

        public float Visina
        {
            get { return _visina; }
            set { _visina = value; }
        }

        public float Duljina
        {
            get { return _sirina; }
            set { _duljina = value; }
        }


        public Prostor(DbDataReader dbReader)
        {
            Sirina = float.Parse(dbReader["sirina"].ToString());
            Visina = float.Parse(dbReader["visina"].ToString());
            Duljina = float.Parse(dbReader["duzina"].ToString());
           

        }

        public bool IzmjeniUsluge(List<Usluga> usluga)
        {
            //kod
            return false;
        }

    }

   

}
