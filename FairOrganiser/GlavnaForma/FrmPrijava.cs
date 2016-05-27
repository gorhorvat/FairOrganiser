using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlavnaForma
{
    public partial class FrmPrijava : Form
    {

        string korisnickoIme;
        string lozinka;

        public FrmPrijava()
        {
            InitializeComponent();
        }

        public bool Prijava(string korisnickoIme, string lozinka)
        {
            //kod
            return false;
            
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
                FrmMain glavniIzbornik = new FrmMain();
                glavniIzbornik.ShowDialog();
        }
    }
}
