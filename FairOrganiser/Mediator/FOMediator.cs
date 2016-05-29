using System;
using Abstracts;
using System.Collections.Generic;
using KreiranjeDogadaja;
using Baza;
using ProdajaKarata;
using GeneriranjeIzvjesca;

namespace Mediator
{
    public class FOMediator : AbstractMediator
    {

        private static LogikaDB _logikaDB;
        private static LogikaKD _logikaKD;
        private static LogikaPK _logikaPK;
        private static LogikaGI _logikaGI;

        public FOMediator()
        {

            _logikaDB = new LogikaDB(this);
            _logikaKD = new LogikaKD(this);
            _logikaPK = new LogikaPK(this);
            _logikaGI = new LogikaGI(this);

        }

        public void GetDataDogadaj()
        {
            _logikaKD.SetDataSource(_logikaDB.GetProstori());
        }

        public void GetDataKarta()
        {
            _logikaPK.SetDataSource(_logikaDB.GetDogadaji(), _logikaDB.GetTipoviKarte(), _logikaDB.GetSifraKarte());
        }

        public void GetDataCjenik()
        {
            _logikaPK.SetDataSource(_logikaDB.GetCjenici());
        }

        public void GetDataRacun()
        {
            _logikaPK.SetDataSource(_logikaDB.GetRacuni(), _logikaDB.GetBrojRacuna());
        }

        public void GetDataIzvjesce()
        {
            _logikaGI.SetDataSource(_logikaDB.GetIzvjesca());
        }

        public override void Send<T>(string message, List<T> values, AbstractUser from)
        {
                if(message == "DBEXEC")
                _logikaDB.Receive(from,"DBEXEC",values);
                    
        }
    }

      
    
}
