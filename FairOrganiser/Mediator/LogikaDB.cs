﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using Abstracts;
using Baza;

namespace Mediator
{
    public class LogikaDB
    {

        //dblogic


        public List<Prostor> GetProstori ()
        {
            List<Prostor> lista = new List<Prostor>();

            DbDataReader dbReader = Baza.DB.Instance.GetDataReader("Select * from Prostor");
            while(dbReader.Read())
            {
                Baza.Prostor prostor = new Baza.Prostor(dbReader);
                lista.Add(prostor);
            }

            dbReader.Close();
            return lista;

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
                   

                    int result = DB.Instance.Insert(d.Naziv, d.Pocetak);
                    Console.WriteLine(result);
                }
                
            }
        }

    }
}
