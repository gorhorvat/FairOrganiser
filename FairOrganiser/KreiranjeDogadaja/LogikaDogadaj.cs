using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        private static int id;
        public static List<int> selectedID;        
        private static FrmDogadaj form;
        private static FrmOrganizatorDogadaj formOrg;
        private static FrmProstorOprema formOpr;

        public LogikaDogadaj()
        {
            selectedID = new List<int>();
            

            

        }

        internal BindingList<Organizator> GetOrganizatoriBindingList()
        {
            using (var context = new KreiranjeDogadajaEntities())
            {
                var organizatori = context.Organizators.ToList();
                BindingList<Organizator> org = new BindingList<Organizator>(organizatori);
                return org;
            }
        }

        internal void AddOrganizator(DataGridViewSelectedRowCollection selectedRows)
        {
            using (var context = new KreiranjeDogadajaEntities())
            {

                Dogadaj d = new Dogadaj { id = id };
                context.Dogadajs.Add(d);
                context.Dogadajs.Attach(d);

                foreach(DataGridViewRow row in selectedRows)
                {

                    var item = row.DataBoundItem as Organizator;

                    Organizator o = new Organizator { id = item.id };
                    context.Organizators.Add(o);
                    context.Organizators.Attach(o);

                    d.Organizators.Add(o);               
                    
                }                              
                
                context.SaveChanges();

                formOrg.Close();
                MessageBox.Show("Organizatori su dodani.");
                
            }
            

        }

        public static List<Prostor> GetAvailable(DateTime datumOd, DateTime datumDo)
        {

            using (var context = new KreiranjeDogadajaEntities())
            {
               // var available = context.Prostors.SqlQuery("select * from Prostor where Prostor.id not in(select Prostor.id from Dogadaj join Prostor on Dogadaj.id = Prostor.Dogadajid where DatumOd >= '2016-06-15 21:40:20.000' and DatumDo <= '2016-07-15 19:41:41.000');").ToList();
               
                var availableQuery =(from p in context.Prostors 
                                    join d in context.Dogadajs on p.Dogadajid equals d.id
                                    where d.datumOd <= datumDo && d.datumDo >= datumOd
                                    select p.id);

                var available = context.Prostors.Where(x => !availableQuery.ToList().Contains(x.id)).ToList();
                return available;
            }

        }

        internal void DodajOpremu()
        {
            formOpr = new FrmProstorOprema(this);
            formOpr.ShowDialog();

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

            Dogadaj newDogadaj = new Dogadaj();
            if (selectedID.Count == 0)
            {
                return;
            }
            else
            {


                
                newDogadaj.naziv = naziv;
                newDogadaj.cijenaKarte = cijena;
                newDogadaj.datumOd = datumOd;
                newDogadaj.datumDo = datumDo;


                using (var context = new KreiranjeDogadajaEntities())
                {
                    
                    context.Dogadajs.Add(newDogadaj);
                    context.SaveChanges();

                    var update = context.Prostors.Where(p => selectedID.Contains(p.id)).ToList();

                    foreach(Prostor p in update)
                    {
                        p.Dogadajid = newDogadaj.id;
                        id = newDogadaj.id;
                    }

                    context.SaveChanges();

                }

                

                MessageBox.Show("Događaj je dodan.");


                form.MakeButtonsVisible();
                

            }
        }

        internal void DodajOrganizatore()
        {

            formOrg = new FrmOrganizatorDogadaj(this);
            formOrg.ShowDialog();

        }

        public void AddForm(FrmDogadaj dogadaj)
        {
            form = dogadaj;
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
