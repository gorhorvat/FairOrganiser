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
    public partial class FrmIzvjesceBrojPosjetitelja : Form
    {
        public FrmIzvjesceBrojPosjetitelja()
        {
            InitializeComponent();
        }

        private void FrmIzvjesce_Load(object sender, EventArgs e)
        {
            this.IzvjesceBrojPosjetiteljaTableAdapter.BrojPosjetitelja(this._16057_IzvjescaDBDataSet.IzvjesceBrojPosjetitelja);
            this.rvPodaci.RefreshReport();
        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
