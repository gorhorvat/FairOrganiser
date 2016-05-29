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
        FrmCjenik FrmCjenik;
        FrmKarta karta;
        FrmRacun racun;
        FrmNoviTip noviTip;
        FrmNovaStavka novaStavka;
        FrmPregledCjenika pregled;

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

        public void StartCjenik()
        {
            FrmCjenik = new FrmCjenik(this);
            FrmCjenik.Show();
        }

        public void StartNoviTip()
        {
            noviTip = new FrmNoviTip(this);
            noviTip.Show();
        }

        public void StartPregledCjenika()
        {
            pregled = new FrmPregledCjenika(this);
            pregled.Show();
        }

        public void StartRacun()
        {
            racun = new FrmRacun(this);
            racun.Show();
        }

        public void StartNovaStavka()
        {
            novaStavka = new FrmNovaStavka(this);
            novaStavka.Show();
        }

        public void SetDataSource(List<Dogadaj> dogadaj, List<TipKarte> tip, string sifraKarte)
        {
            StartKarta();
            karta.SetDataSource(dogadaj, tip, sifraKarte);
            _dogadaj = dogadaj;
            _tip = tip;
        }

        public void SetDataSource(List<Cjenik> cjenik)
        {
            StartCjenik();
            FrmCjenik.SetDataSource(cjenik);
        }

        public void SetDataSource(List<Racun> racuni, string brojRacuna)
        {
            StartRacun();
            racun.SetDataSource(racuni, brojRacuna);
        }

        // Ovo vjerojatno nije potrebno
        public void SaveKarta(Karta karta)
        {
            List<Karta>lista = new List<Karta>();
            lista.Add(karta);
            Mediator.Send("DBEXEC", lista, this);
        }

        public void SaveCjenik(Cjenik cjenik)
        {
            List<Cjenik> lista = new List<Cjenik>();
            lista.Add(cjenik);
            Mediator.Send("DBEXEC", lista, this);
        }

        public void SaveRacun(Racun racun)
        {
            List<Racun> lista = new List<Racun>();
            lista.Add(racun);
            Mediator.Send("DBEXEC", lista, this);
        }

        public float GetCijenaKarte(int dgvIndex1, int dgvIndex2)
        {
            Dogadaj dog = _dogadaj[dgvIndex1];
            TipKarte tip = _tip[dgvIndex2];

            float cijena = (float)dog.CijenaKarte - ((float)dog.CijenaKarte * ((float)tip.IznosPopusta / 100));
            return cijena;
        }

        public override void Receive<T>(AbstractUser from, string message, List<T> lista)
        {
            throw new NotImplementedException();
        }
    }
}
