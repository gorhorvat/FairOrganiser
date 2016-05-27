using System;
using Abstracts;
using System.Collections.Generic;
using KreiranjeDogadaja;
using Baza;

namespace Mediator
{
    public class FOMediator : AbstractMediator
    {

        private static LogikaDB _logikaDB;
        private static LogikaKD _logikaKD;

        public FOMediator()
        {

            _logikaDB = new LogikaDB();
            _logikaKD = new LogikaKD(this);

        }

        public void GetDataDogadaj()
        {
            _logikaKD.SetDataSource(_logikaDB.GetProstori());
        }

        

        public override void Send<T>(string message, List<T> values, AbstractUser from)
        {
                if(message == "DBEXEC")
                _logikaDB.SaveStuff(values);
                    
        }
    }

      
    
}
