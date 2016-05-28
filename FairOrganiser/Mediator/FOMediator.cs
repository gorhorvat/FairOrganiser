using System;
using Abstracts;
using System.Collections.Generic;
using KreiranjeDogadaja;
using Baza;
using ProdajaKarata;

namespace Mediator
{
    public class FOMediator : AbstractMediator
    {

        private static LogikaDB _logikaDB;
        private static LogikaKD _logikaKD;
        private static LogikaPK _logikaPK;

        public FOMediator()
        {

            _logikaDB = new LogikaDB(this);
            _logikaKD = new LogikaKD(this);
            _logikaPK = new LogikaPK(this);

        }

        public void GetDataDogadaj()
        {
            _logikaKD.SetDataSource(_logikaDB.GetProstori());
        }

        public void GetDataKarta()
        {
            _logikaPK.SetDataSource(_logikaDB.GetDogadaji(), _logikaDB.GetTipoviKarte(), _logikaDB.GetSifraKarte());
        }

        

        public override void Send<T>(string message, List<T> values, AbstractUser from)
        {
                if(message == "DBEXEC")
                _logikaDB.Receive(from,"DBEXEC",values);
                    
        }
    }

      
    
}
