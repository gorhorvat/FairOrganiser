using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Dogadaj
    {

        string _naziv;
        float _cijenaKarte;
        DateTime _pocetak;
        DateTime _kraj;
        VizualniPrikaz prikaz;
        List<Prostor> prostori;
        List<Organizator> organizatori;
        List<Sudionik> sudionici;
        List<Racun> racuni;


        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public float CijenaKarte
        {
            get { return _cijenaKarte; }
            set { _cijenaKarte = value; }
        }

        public DateTime Pocetak
        {
            get { return _pocetak; }
            set { _pocetak = value; }
        }

        public DateTime Kraj
        {
            get { return _kraj; }
            set { _kraj = value; }
        }

        public Dogadaj(string naziv, float cijena, DateTime pocetak, DateTime kraj)
        {
            _cijenaKarte = cijena;
            _naziv = naziv;
            _pocetak = pocetak;
            _kraj = kraj;
        }

        public Dogadaj(DbDataReader dbReader)
        {
            _cijenaKarte = float.Parse(dbReader["cijenaKarte"].ToString());
            _naziv = dbReader["naziv"].ToString();
            DateTime.TryParse(dbReader["datumOd"].ToString(), out _pocetak);
            DateTime.TryParse(dbReader["datumDo"].ToString(), out _kraj);
        }

        public bool IzmijeniCijenu(float cijena)
        {
            CijenaKarte = cijena;
            return true;
        }

        public bool IzmjeniDogadaj()
        {
            //kod
            return false;
        }

        public bool IzmjeniProstor()
        {
            //kod
            return false;
        }

        public bool IzmjeniOrganizator()
        {
            //kod
            return false;
        }

        public bool IzmjeniSudionike()
        {
            //kod
            return false;
        }

        public bool IzmjeniRacun()
        {
            //kod
            return false;
        }


    }
}
