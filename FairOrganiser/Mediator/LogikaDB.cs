using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using Abstracts;
using Baza;

namespace Mediator
{
    public class LogikaDB : AbstractUser
    {
        
        //dblogic

        public LogikaDB(AbstractMediator mediator) :base(mediator)
        {
            Mediator = mediator;
        }


        public List<Prostor> GetProstori ()
        {
            List<Prostor> lista = new List<Prostor>();

            DbDataReader dbReader = DB.Instance.GetDataReader("Select * from Prostor");
            while(dbReader.Read())
            {
                Prostor prostor = new Prostor(dbReader);
                lista.Add(prostor);
            }

            dbReader.Close();
            return lista;
        }

        public List<Dogadaj> GetDogadaji()
        {
            List<Dogadaj> lista = new List<Dogadaj>();
            DbDataReader dbReader = DB.Instance.GetDataReader("Select * from Dogadaj");
            while (dbReader.Read())
            {
                Dogadaj dogadaj = new Dogadaj(dbReader);
                lista.Add(dogadaj);
            }
            dbReader.Close();
            return lista;
        }

        public List<TipKarte> GetTipoviKarte()
        {
            List<TipKarte> lista = new List<TipKarte>();
            DbDataReader dbReader = DB.Instance.GetDataReader("Select * from TipKarte");
            while (dbReader.Read())
            {
                TipKarte tip = new TipKarte(dbReader);
                lista.Add(tip);
            }
            dbReader.Close();
            return lista;
        }

        public string GetSifraKarte()
        {
            return ((int) DB.Instance.GetValue("Select count(*) from Karta;")+1).ToString();
        }

        public List<Cjenik> GetCjenici()
        {
            List<Cjenik> lista = new List<Cjenik>();
            DbDataReader dbReader = DB.Instance.GetDataReader("Select * from CjenikDogadaja");
            while (dbReader.Read())
            {
                Cjenik cjenik = new Cjenik(dbReader);
                lista.Add(cjenik);
            }
            dbReader.Close();
            return lista;
        }

        //Sigurno nije Select *, treba definirati što se select-a!!
        public List<Racun> GetRacuni()
        {
            List<Racun> lista = new List<Racun>();
            DbDataReader dbReader = DB.Instance.GetDataReader("Select * from Racun");
            while (dbReader.Read())
            {
                Racun racun = new Racun(dbReader);
                lista.Add(racun);
            }
            dbReader.Close();
            return lista;
        }

        public List<Izvjesce> GetIzvjesca()
        {
            List<Izvjesce> lista = new List<Izvjesce>();

            return lista;
        }

        public string GetBrojRacuna()
        {
            return ((int)DB.Instance.GetValue("Select count(*) from Racun;") + 1).ToString();
        }

        public override void Receive<T>(AbstractUser from, string message, List<T> lista)
        {
            if (typeof(Dogadaj) == typeof(T))
            {
                //kod za dodavanje dogadaja

                var newStuff = new List<Dogadaj>();

                newStuff = (List<Dogadaj>)(object)lista;

                foreach (Dogadaj d in newStuff)
                {
                    int result = DB.Instance.Insert(d.Naziv, d.Pocetak, d.Kraj, d.CijenaKarte);
                    Console.WriteLine(result);
                }
            }

            if (typeof(Cjenik) == typeof(T))
            {
                //kod za dodavanje cjenika

                var newStuff = new List<Cjenik>();

                newStuff = (List<Cjenik>)(object)lista;

                foreach (Cjenik c in newStuff)
                {
                    int result = DB.Instance.Insert(c.VrijediOd, c.VrijediDo);
                    Console.WriteLine(result);
                }
            }
            // Izmjeniti kad napravimo upite za vanjske ključeve
            if (typeof(Karta) == typeof(T))
            {
                //kod za dodavanje karte

                var newStuff = new List<Karta>();

                newStuff = (List<Karta>)(object)lista;

                foreach (Karta k in newStuff)
                {
                    int result = DB.Instance.Insert(k.Datum);
                    Console.WriteLine(result);
                }
            }

            if (typeof(Racun) == typeof(T))
            {
                //kod za dodavanje računa

                var newStuff = new List<Racun>();

                newStuff = (List<Racun>)(object)lista;

                foreach (Racun r in newStuff)
                {
                    int result = DB.Instance.Insert(r.Operater, r.Vrijeme, r.NazivTvrtke, r.Sjediste, r.Oib, r.Ukupno, r.NazivKupca);
                    Console.WriteLine(result);
                }
            }

        }

        /*
public List<Organizator> GetOrganizatori ()
{
   List<Organizator> lista = new List<Organizator>();

   DbDataReader dbReader = DB.Instance.GetDataReader("Select * from Organizator");

   while(dbReader.Read())
   {
       if(int.Parse(dbReader["TipOrganizaotraid"].ToString()) == 0) //fizicka osoba
       {
           FizickaOsoba fo = new FizickaOsoba(dbReader);
       }
       else
       {
           PravnaOsoba po = new PravnaOsoba(dbReader);
       }

   }

}

*/


        public void SaveStuff<T> (List<T> stuff)
        {
            if(typeof(Dogadaj) == typeof(T))
            {
                //kod za dodavanje dogadaja

                var newStuff = new List<Dogadaj>();

                newStuff = (List<Dogadaj>)(object)stuff;

                foreach(Dogadaj d in newStuff)
                {
                   

                    int result = DB.Instance.Insert(d.Naziv, d.Pocetak, d.Kraj, d.CijenaKarte);
                    Console.WriteLine(result);
                }
                
            }
        }

    }
}
