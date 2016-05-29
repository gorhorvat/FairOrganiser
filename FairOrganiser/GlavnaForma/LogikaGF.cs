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

        public static void StartCjenik()
        {
            _mediator.GetDataCjenik();
        }

        public static void StartRacun()
        {
            _mediator.GetDataRacun();
        }

        public static void StartIzvjesce()
        {
            _mediator.GetDataIzvjesce();
        }

        public static void StartUsluga()
        {
            
        }
    }
}
