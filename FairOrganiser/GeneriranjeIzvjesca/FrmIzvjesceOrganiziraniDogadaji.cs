﻿using System;
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
    public partial class FrmIzvjesceOrganiziraniDogadaji : Form
    {
        public FrmIzvjesceOrganiziraniDogadaji()
        {
            InitializeComponent();
        }

        private void FrmIzvjesceOrganiziraniDogadaji_Load(object sender, EventArgs e)
        {
            this.IzvjesceOrganizatoriTableAdapter.OrganiziraniDogadaji(this._16057_IzvjescaDBDataSet.IzvjesceOrganizatori);
            this.rvPodaci.RefreshReport();
        }
    }
}
