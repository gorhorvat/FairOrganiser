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

namespace GeneriranjeIzvjesca
{
    public partial class FrmIzvjesce : Form
    {
        LogikaGI _logikaGI;

        public FrmIzvjesce(LogikaGI logikaGI)
        {
            _logikaGI = logikaGI;
            InitializeComponent();
        }

        public void SetDataSource(List<Izvjesce> izvjesce)
        {

        }

        private void btnIspisiIzvjestaj_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
