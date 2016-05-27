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
