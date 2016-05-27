using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstracts;
using Baza;

namespace KreiranjeDogadaja
{
    public partial class FrmDogadaj : Form 
    {

        LogikaKD _logikaKD;
        


        public FrmDogadaj(LogikaKD logikaKD)
        {
            _logikaKD = logikaKD;
            InitializeComponent();
        }

        

        public void SetDataSource(List<Prostor> prostor)
        {
            dgvProstori.DataSource = prostor;
           // dgvOrganizatori.DataSource = organizator;
        }

        private void btnDodajDogadaj_Click(object sender, EventArgs e)
        {
            Dogadaj d = new Dogadaj(tbNaziv.Text, dtpPocetak.Value, dtpZavrsetak.Value);
            _logikaKD.SaveDogadaj(d);
        }
    }
}
