using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreiranjeDogadaja
{
    public class LogikaDogadaj
    {
        public static List<int> selectedID;
        public static Dogadaj newDogadaj;
        private static FrmDogadaj form;

        public LogikaDogadaj()
        {
            selectedID = new List<int>();
            form = new FrmDogadaj(this);
                               
            form.ShowDialog();

            

        }


        public static List<Prostor> GetAvailable(DateTime datumOd, DateTime datumDo)
        {

            using (var context = new KreiranjeDogadajaEntities())
            {
               // var available = context.Prostors.SqlQuery("select * from Prostor where Prostor.id not in(select Prostor.id from Dogadaj join Prostor on Dogadaj.id = Prostor.Dogadajid where DatumOd >= '2016-06-15 21:40:20.000' and DatumDo <= '2016-07-15 19:41:41.000');").ToList();
               
                var availableQuery =(from p in context.Prostors 
                                    join d in context.Dogadajs on p.Dogadajid equals d.id
                                    where d.datumOd >= datumOd && d.datumDo <= datumDo
                                    select p.id);

                var available = context.Prostors.Where(x => !availableQuery.ToList().Contains(x.id)).ToList();
                return available;
            }

        }


       public void ColorPanel(DateTime datumOd, DateTime datumDo)
        {
                      
            var improvedPanels = form.GetAll();

            var available = GetAvailable(datumOd,datumDo);

            foreach(ImprovedPanel ip in improvedPanels)
            {
                ip.BackColor = Color.Red;
                ip.Available = false;
                
            }

            foreach(Prostor p in available)
            {

                
                ImprovedPanel ipAvail = improvedPanels.Where(e => e.ID == p.id).FirstOrDefault();
               
                ipAvail.BackColor = Color.Green;
                ipAvail.Available = true;
                
                form.Refresh();
            }


            
        }

        internal static void RefreshForm()
        {
            form.Refresh();
        }

        internal static void CreateDogadaj(string naziv, float cijena, DateTime datumOd, DateTime datumDo)
        {

            if (selectedID.Count == 0)
            {
                return;
            }
            else
            {


                newDogadaj = new Dogadaj();
                newDogadaj.naziv = naziv;
                newDogadaj.cijenaKarte = cijena;
                newDogadaj.datumOd = datumOd;
                newDogadaj.datumDo = datumDo;


                using (var context = new KreiranjeDogadajaEntities())
                {
                    newDogadaj.id = context.Dogadajs.Count() + 1;
                    context.Dogadajs.Add(newDogadaj);
                    context.SaveChanges();

                    var update = context.Prostors.Where(p => selectedID.Contains(p.id)).ToList();

                    foreach(Prostor p in update)
                    {
                        p.Dogadajid = newDogadaj.id;
                    }

                    context.SaveChanges();

                }

                

                MessageBox.Show("Događaj je dodan.");
                        
                

            }
        }

        internal static void AddToList(object sender)
        {
            ImprovedPanel ip = sender as ImprovedPanel;
           if (ip.Available)
            {
                if(ip.Selected)
                {
                    selectedID.Add(ip.ID);
                }
                else
                {
                    if(selectedID.Count > 0)
                    {
                        selectedID.Remove(ip.ID);
                    }
                    
                }
            }
        }



    }
}
