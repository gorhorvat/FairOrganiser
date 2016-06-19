using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EvidencijaOrganizatora
{
    public partial class FrmEvidencija : Form
    {
        public FrmEvidencija()
        {
            InitializeComponent();
        }

        private void FrmEvidencija_Load(object sender, EventArgs e)
        {
            PrikaziOrganizatore();
        }
        /// <summary>
        /// Dohvaća listu organizatora te ih prikazuje u dgv-u.
        /// </summary>
        private void PrikaziOrganizatore()
        {
            BindingList<Organizator> ListaOrganizatora = null;
            using(var db = new evidencijaOrganizatoraEntities())
            {
                ListaOrganizatora = new BindingList<Organizator>(db.Organizators.ToList());
            }
            organizatorBindingSource.DataSource = ListaOrganizatora;
        }

        /// <summary>
        /// Brisanje organizatora sa odabranim ID-om.
        /// </summary>
        /// <param name="OrganizatorID"></param>
        private void ObrisiOrganizatora(int OrganizatorID)
        {
            using (var db = new evidencijaOrganizatoraEntities())
            {
                Organizator brisiOrganizator = (from s in db.Organizators
                                          where s.id == OrganizatorID
                                          select s).First();

                if (brisiOrganizator != null)
                {
                    if (MessageBox.Show("Da li ste sigurni? ", "Upozorenje!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        db.Organizators.Remove(brisiOrganizator);
                        db.SaveChanges();
                    }
                }
            }
        }
        /// <summary>
        /// Brisanje označenog organizatora sa liste te iz baze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnObrisiOrganizatora_Click(object sender, EventArgs e)
        {
            int OrganizatorID = int.Parse(dgvOrganizatori[0, dgvOrganizatori.CurrentRow.Index].Value.ToString());
            ObrisiOrganizatora(OrganizatorID);
            PrikaziOrganizatore();
        }
    }

}
