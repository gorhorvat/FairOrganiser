using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneriranjeIzvjesca
{
    public partial class FrmIzvjesce : Form
    {
        public FrmIzvjesce()
        {
            InitializeComponent();
        }

        private void FrmIzvjesce_Load(object sender, EventArgs e)
        {
            List<string> popisIzvjesca = new List<string>() { "Izvješće o broju posjetitelja", "Izvješće o prodanim uslugama", "Izvješće o popunjenosti kapaciteta", "Izvješće o organiziranim događajima" };
            cmbNazivIzvjesca.DataSource = popisIzvjesca;
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
