using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreiranjeDogadaja
{
    public partial class FrmOrganizatorDogadaj : Form
    {

        private static LogikaDogadaj logic;

        public FrmOrganizatorDogadaj(LogikaDogadaj log)
        {
            logic = log;
            InitializeComponent();
        }

        private void FrmOrganizatorDogadaj_Load(object sender, EventArgs e)
        {
            organizatorBindingSource.DataSource = logic.GetOrganizatoriBindingList();
        }

        private void btnDodajOrganizatore_Click(object sender, EventArgs e)
        {

            logic.AddOrganizator(dgvOrganizatori.SelectedRows);

        }
    }
}
