using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KreiranjeDogadaja
{
    public class Dogadaj
    {

        string naziv;
        DateTime pocetak;
        DateTime kraj;
        VizualniPrikaz prikaz;
        List<Prostor> prostori;
        //List<???.Organizator> organizatori;
        //List<???.Sudionik> sudionici;
        List<ProdajaKarata.Racun> racuni;


        public Dogadaj(string naziv, DateTime pocetak, DateTime kraj)
        {
            this.naziv = naziv;
            this.pocetak = pocetak;
            this.kraj = kraj;
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
