using Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baza;

namespace KreiranjeDogadaja 
{
    public class LogikaKD :AbstractUser
    {

        private static FrmDogadaj dogadaj;


        public LogikaKD(AbstractMediator mediator) : base (mediator)
        {
            

            Mediator = mediator;
             
            
        }

        public void StartDogadaj()
        {
            dogadaj = new FrmDogadaj(this);
            dogadaj.Show();
        }

        

        public void SetDataSource(List<Prostor> prostor)
        {
            StartDogadaj();

            

            dogadaj.SetDataSource(prostor);
            
        }

        public void SaveDogadaj (Dogadaj dogadaj)
        {

            List<Dogadaj> lista = new List<Dogadaj>();
            lista.Add(dogadaj);
            Mediator.Send("DBEXEC",lista, this);
        }

        public override void Receive(AbstractUser from, string message)
        {
            throw new NotImplementedException();
        }
    }
}
