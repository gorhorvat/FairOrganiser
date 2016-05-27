using Abstracts;
using Baza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdajaKarata
{
    public class LogikaPK : AbstractUser
    {
        FrmCjenik cjenik;
        FrmKarta karta;
        FrmRacun racun;
        FrmNoviTip noviTip;
        FrmNovaStavka novaStavka;

        public LogikaPK(AbstractMediator mediator) : base(mediator)
        {
            Mediator = mediator;
        }

        public void StartKarta()
        {
            karta = new FrmKarta(this);
            karta.Show();
        }

        public void SetDataSource(List<Dogadaj> dogadaj, List<TipKarte> tip)
        {
            StartKarta();
            karta.SetDataSource(dogadaj, tip);

        }

        public void SaveKarta(Karta karta)
        {
            List<Karta>lista = new List<Karta>();
            lista.Add(karta);
            Mediator.Send("DBEXEC", lista, this);
        }

        public override void Receive<T>(AbstractUser from, string message, List<T> lista)
        {
            throw new NotImplementedException();
        }
    }
}
