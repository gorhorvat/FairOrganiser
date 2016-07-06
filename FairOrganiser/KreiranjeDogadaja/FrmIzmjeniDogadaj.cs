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
    public partial class FrmIzmjeniDogadaj : Form
    {

        private int id;

        public FrmIzmjeniDogadaj(int id)
        {
            this.id = id;
            InitializeComponent();
            Fill(id);
        }

        private void Fill(int id)
        {
            using (var context = new KreiranjeDogadajaEntities())
            {
                var dogadaj = (from dog in context.Dogadajs where dog.id == id select dog).FirstOrDefault();

                txtNaziv.Text = dogadaj.naziv;
                txtCijena.Text = dogadaj.cijenaKarte.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new KreiranjeDogadajaEntities())
            {
                var dogadaj = (from dog in context.Dogadajs where dog.id == id select dog).FirstOrDefault();
                if (txtNaziv.Text != "")
                {
                    dogadaj.naziv = txtNaziv.Text;
                }

                double cijena;

                if (double.TryParse(txtCijena.Text, out cijena))
                {
                    dogadaj.cijenaKarte = cijena;
                }

                context.SaveChanges();

            }
            LogikaDogadaj.UpdateFormPrikaz();
        }
    }
}
