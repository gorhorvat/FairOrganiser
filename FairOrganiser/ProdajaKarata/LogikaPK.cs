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

        List<Dogadaj> _dogadaj;
        List<TipKarte> _tip;

        public LogikaPK(AbstractMediator mediator) : base(mediator)
        {
            Mediator = mediator;
        }

        public void StartKarta()
        {
            karta = new FrmKarta(this);
            karta.Show();
        }

        public void SetDataSource(List<Dogadaj> dogadaj, List<TipKarte> tip, string sifraKarte)
        {
            StartKarta();
            karta.SetDataSource(dogadaj, tip, sifraKarte);
            _dogadaj = dogadaj;
            _tip = tip;

        }

        public void SaveKarta(Karta karta)
        {
            List<Karta>lista = new List<Karta>();
            lista.Add(karta);
            Mediator.Send("DBEXEC", lista, this);
        }

        public float GetCijenaKarte(int dgvIndex1, int dgvIndex2)
        {
            Dogadaj dog = _dogadaj[dgvIndex1];
            TipKarte tip = _tip[dgvIndex2];

            float cijena = dog.CijenaKarte - (dog.CijenaKarte * (tip.IznosPopusta / 100));
            return cijena;
        }

        public override void Receive<T>(AbstractUser from, string message, List<T> lista)
        {
            throw new NotImplementedException();
        }
    }
}
