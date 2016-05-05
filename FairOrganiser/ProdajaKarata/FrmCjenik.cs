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
    public partial class FrmCjenik : Form
    {
        public List<TipKarte> listaTipova = new List<TipKarte>();
        //private Cjenik noviCjenik;

        public FrmCjenik()
        {
            InitializeComponent();
        }
    }
}
