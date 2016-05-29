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
    public partial class FrmCjenik : Form
    {
        LogikaPK _logikaPK;

        public FrmCjenik(LogikaPK logikaPK)
        {
            _logikaPK = logikaPK;
            InitializeComponent();
        }

        public void SetDataSource(List<Cjenik> cjenik)
        {
            dgvPopisCjenika.DataSource = cjenik;
        }

        private void btnDodajCjenik_Click(object sender, EventArgs e)
        {
            Cjenik c = new Cjenik(dtpOd.Value.Date, dtpDo.Value.Date);
            _logikaPK.SaveCjenik(c);
        }

        private void btnObrisiCjenik_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            _logikaPK.StartPregledCjenika();
        }
    }
}
