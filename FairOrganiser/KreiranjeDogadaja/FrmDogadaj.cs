using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KreiranjeDogadaja
{
    public partial class FrmDogadaj : Form
    {

        private LogikaDogadaj logic;


        public FrmDogadaj(LogikaDogadaj log)
        {



            logic = log;
            
            InitializeComponent();

           
            


        }

        


        public IEnumerable<ImprovedPanel> GetAll()
        {
            var c = from controls in this.Controls.OfType<ImprovedPanel>() select controls;

            return c;
        }

        private void dtpPocetak_ValueChanged(object sender, EventArgs e)
        {
            logic.ColorPanel(dtpPocetak.Value,dtpZavrsetak.Value);
        }

        private void dtpZavrsetak_ValueChanged(object sender, EventArgs e)
        {
            logic.ColorPanel(dtpPocetak.Value, dtpZavrsetak.Value);
        }

        private void FrmDogadaj_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnDodajDogadaj_Click(object sender, EventArgs e)
        {
            float cijena;
            string naziv = txtNaziv.Text;
            bool check = true;
            if (naziv == null || naziv == "")
            {
                txtNaziv.BackColor = Color.Salmon;
                timerNaziv.Start();
                check = false;
            }

            if (float.TryParse(txtCijenaKarte.Text, out cijena) == false)
            {
                txtCijenaKarte.BackColor = Color.Salmon;
                timerCijena.Start();
                check = false;
            }

            DateTime datumOd = dtpPocetak.Value;
            DateTime datumDo = dtpZavrsetak.Value;

            if (check == true)
            {
                LogikaDogadaj.CreateDogadaj(naziv, cijena, datumOd, datumDo);
            }
            
        }

        private void timerNaziv_Tick(object sender, EventArgs e)
        {
            txtNaziv.BackColor = default(Color);
        }

        private void timerCijena_Tick(object sender, EventArgs e)
        {
            txtCijenaKarte.BackColor = default(Color);
        }

        

        private void btnDodajOrganizatore_Click(object sender, EventArgs e)
        {
            logic.DodajOrganizatore();
        }

        internal void MakeButtonsVisible()
        {
            btnDodajOrganizatore.Visible = true;
            btnDodajOpremu.Visible = true;
            
        }

        private void btnDodajOpremu_Click(object sender, EventArgs e)
        {
            logic.DodajOpremu();
        }
    }
}
