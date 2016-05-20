using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidencijaSudionika
{
    public partial class FrmSudionik : Form
    {
        
        public FrmSudionik()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmNoviSudionik noviSudionik = new FrmNoviSudionik();
            noviSudionik.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmAkreditacija novaAkreditacija = new FrmAkreditacija();
            novaAkreditacija.ShowDialog();
        }
    }
}
