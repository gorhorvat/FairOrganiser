﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GlavnaForma
{
    static class Program 
    {

        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        
        [STAThread]
        static void Main()
        {

            LogikaGF log = new LogikaGF();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmPrijava prijava = new FrmPrijava();
            Application.Run(prijava);

            

            
            



        }
    }
}
