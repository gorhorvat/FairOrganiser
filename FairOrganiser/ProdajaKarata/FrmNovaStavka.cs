using Baza;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmNovaStavka : Form
    {
        LogikaPK _logikaPK;

        public FrmNovaStavka(LogikaPK logikaPK)
        {
            _logikaPK = logikaPK;
            InitializeComponent();
        }

        public void SetDataSource(List<Usluga> stavka)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
