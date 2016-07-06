using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreiranjeDogadaja
{
    public partial class FrmPrikazDogadaja : Form
    {

        public static LogikaDogadaj logic;

        public FrmPrikazDogadaja(LogikaDogadaj log)
        {
            logic = log;
            InitializeComponent();

            var dogadaji = logic.GetDogadajBingindList();



            dgvDogadaj.DataSource = dogadaji.Select(s => new {id = s.id,Naziv = s.naziv,Početak = s.datumOd, Završetak = s.datumDo, Cijena_karte = s.cijenaKarte}).ToList();

            dgvDogadaj.Columns[0].Visible = false;
            
        }

        private void dgvDogadaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var selected = dgvDogadaj.SelectedCells[0];


            
            dgvProstor.DataSource = logic.GetProstorBindingList(int.Parse(selected.Value.ToString()));
            dgvUsluge.DataSource = logic.GetUslugaBindingList(int.Parse(selected.Value.ToString()));

            dgvProstor.Columns[0].Visible = false;
            dgvProstor.Columns[4].Visible = false;
            dgvProstor.Columns[5].Visible = false;

            dgvUsluge.Columns[0].Visible = false;
            dgvUsluge.Columns[5].Visible = false;
        }

        private void btnIzmjeniDogadaj_Click(object sender, EventArgs e)
        {
            var selected = dgvDogadaj.SelectedCells[0];
            FrmIzmjeniDogadaj frm = new FrmIzmjeniDogadaj(int.Parse(selected.Value.ToString()));
            frm.ShowDialog();
        }
    }
}
