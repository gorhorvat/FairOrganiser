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
    public partial class FrmNoviOrganizator : Form
    {
        public FrmNoviOrganizator()
        {
            InitializeComponent();
        }

        private void FrmNoviOrganizator_Load(object sender, EventArgs e)
        {
            PrikaziTipove();
            if (cmbTip.Text == "Fizicka osoba")
            {
                panelFizicka.Show();
                panelPravna.Hide();
            }
            else
            {
                panelPravna.Show();
                panelFizicka.Hide();
            }
        }
        /// <summary>
        /// Dohvacanje tipova organizatora iz baze.
        /// </summary>
        private void PrikaziTipove()
        {
            BindingList<TipOrganizatora> listaTipova = null;
            using (var db = new evidencijaOrganizatoraEntities())
            {
                listaTipova = new BindingList<TipOrganizatora>(db.TipOrganizatoras.ToList());
            }
            tipOrganizatoraBindingSource.DataSource = listaTipova;
        }
        /// <summary>
        /// Prikaz drugačijih kontrola za unos podataka o organizatoru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.Text == "Fizicka osoba")
            {
                panelFizicka.Show();
                panelPravna.Hide();
            }
            else
            {
                panelPravna.Show();
                panelFizicka.Hide();
            }
        }
    }
}
