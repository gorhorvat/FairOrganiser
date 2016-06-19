using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreiranjeDogadaja
{
    public class LogikaDogadaj
    {


        public LogikaDogadaj()
        {

            FrmDogadaj form = new FrmDogadaj(this);
            GetAvailable();
            form.ShowDialog();
           

        }


        public List<Prostor> GetAvailable()
        {

            using (var context = new KreiranjeDogadajaEntities())
            {
                var available = context.Prostors.SqlQuery("Select * from Prostor").ToList();

                

                return available;
            }



        }


    }
}
