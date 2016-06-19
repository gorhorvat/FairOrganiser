using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KreiranjeDogadaja
{
    public partial class FrmDogadaj : Form
    {

        private LogikaDogadaj logic;

        public FrmDogadaj(LogikaDogadaj log)
        {

            logic = log;

            InitializeComponent();
        }

                
    }
}
