using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoranHorvat
{
    public partial class FrmRacun : Form
    {
        public List<Racun> listaRacuna = new List<Racun>();
        //private Usluga novaStavka;

        public FrmRacun()
        {
            InitializeComponent();
        }
    }
}
