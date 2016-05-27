using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Dogadaj
    {

        string _naziv;
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

        public DateTime Pocetak
        {
            get { return _pocetak; }
            set { _pocetak = value; }
        }

        public Dogadaj(string naziv, DateTime pocetak, DateTime kraj)
        {
            _naziv = naziv;
            _pocetak = pocetak;
            _kraj = kraj;
        }

        public Dogadaj()
        {

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
