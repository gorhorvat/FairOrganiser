using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza
{
    public class Racun
    {
        public List<Usluga> listaStavki;

        int _brojRacuna;
        string _operater;
        DateTime _vrijeme;
        string _nazivTvrtke;
        string _sjediste;
        string _oib;
        float _ukupno;
        string _nazivKupca;

        public int BrojRacuna
        {
            get { return _brojRacuna; }
            set { _brojRacuna = value; }
        }

        public string Operater
        {
            get { return _operater; }
            set { _operater = value; }
        }

        public DateTime Vrijeme
        {
            get { return _vrijeme; }
            set { _vrijeme = value; }
        }

        public string NazivTvrtke
        {
            get { return _nazivTvrtke; }
            set { _nazivTvrtke = value; }
        }

        public string Sjediste
        {
            get { return _sjediste; }
            set { _sjediste = value; }
        }

        public string Oib
        {
            get { return _oib; }
            set { _oib = value; }
        }

        public float Ukupno
        {
            get { return _ukupno; }
            set { _ukupno = value; }
        }

        public string NazivKupca
        {
            get { return _nazivKupca; }
            set { _nazivKupca = value; }
        }

        //Dodati listu usluga u konstruktor
        public Racun(int broj, string operater, DateTime vrijeme, string tvrtka, string sjediste, string oib, float ukupno, string kupac)
        {
            //this.listaStavki = stavke;
            _brojRacuna = broj;
            _operater = operater;
            _vrijeme = vrijeme;
            _nazivTvrtke = tvrtka;
            _sjediste = sjediste;
            _oib = oib;
            _ukupno = ukupno;
            _nazivKupca = kupac;
        }

        public Racun(DbDataReader dbReader)
        {
            _operater = dbReader["operater"].ToString();
            DateTime.TryParse(dbReader["vrijeme"].ToString(), out _vrijeme);
            _nazivTvrtke = dbReader["nazivTvrtke"].ToString();
            _sjediste = dbReader["sjediste"].ToString();
            _oib = dbReader["oib"].ToString();
            _ukupno = float.Parse(dbReader["ukupno"].ToString());
            _nazivKupca = dbReader["nazivKupca"].ToString();
        }

        public void dodajStavku()
        {

        }

        public void obrisiStavku()
        {

        }

        public void ispisiRacun()
        {

        }
    }
}
