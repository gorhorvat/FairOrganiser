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
    public partial class FrmIzvjesceProdaneUsluge : Form
    {
        public FrmIzvjesceProdaneUsluge()
        {
            InitializeComponent();
        }

        private void FrmIzvjesceProdaneUsluge_Load(object sender, EventArgs e)
        {
            this.IzvjesceProdaneUslugeTableAdapter.Fill(this._16057_IzvjescaDBDataSet.IzvjesceProdaneUsluge);
            this.rvPodaci.RefreshReport();
        }
    }
}
