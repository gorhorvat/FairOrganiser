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
    public partial class FrmIspisIzdanihRacunaOperatera : Form
    {
        public FrmIspisIzdanihRacunaOperatera()
        {
            InitializeComponent();
        }

        public string GetZaposlenikUsername()
        {
            using (var context = new GeneriranjeIzvjescaEntities())
            {
                var username = (from z in context.Zaposleniks
                               where z.id == 1
                               select z.username).Single();
                return username;
            }
        }

        private void FrmIspisIzdanihRacunaOperatera_Load(object sender, EventArgs e)
        {
            txtZaposlenik.Text = GetZaposlenikUsername();
            this.IzvjesceIspisIzdanihRacunaZaposlenikTableAdapter.FillbyUsername(this._16057_IzvjescaDBDataSet.IzvjesceIspisIzdanihRacunaZaposlenik, GetZaposlenikUsername());
            this.rvPodaci.RefreshReport();
        }
    }
}
