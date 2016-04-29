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
    public partial class FrmKarta : Form
    {
        public List<Karta> listaKarata = new List<Karta>();
        //private Karta novaKarta;

        public FrmKarta()
        {
            InitializeComponent();
        }
    }
}
