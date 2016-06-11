using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProdajaKarata
{
    public partial class FrmNovaStavka : Form
    {
        public FrmNovaStavka()
        {
            InitializeComponent();
        }

        private void FrmNovaStavka_Load(object sender, EventArgs e)
        {
            PrikaziUsluge();
        }

        /// <summary>
        /// Dohvaća listu svih usluga u kontekstu, te ih prikazuje u ComboBox-u.
        /// </summary>
        private void PrikaziUsluge()
        {
            BindingList<Usluga> popisUsluga = null;
            using (var db = new ProdajaKarataEntities())
            {
                popisUsluga = new BindingList<Usluga>(db.Uslugas.ToList());
            }
            uslugaBindingSource.DataSource = popisUsluga;
        }

        private void dgvUsluge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCijena.Text = float.Parse(dgvUsluge[4, dgvUsluge.CurrentRow.Index].Value.ToString()).ToString("N", CultureInfo.InvariantCulture);
        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {

        }

        private void btnPotvrdi_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
