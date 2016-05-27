using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator;


namespace GlavnaForma
{
    public class LogikaGF 
    {

        private static FOMediator _mediator;


        public LogikaGF()
        {
            _mediator = new FOMediator();
        }

        public static void StartDogadaj()
        {
            _mediator.GetDataDogadaj();
        }

        public static void StartKarta()
        {
            _mediator.GetDataKarta();
        }

    }
}
