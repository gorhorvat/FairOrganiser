﻿using iTextSharp.text;
using iTextSharp.text.pdf;
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
        private static int dogadajId;
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

                Dogadaj d = new Dogadaj { id = dogadajId };
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

        internal void AddOprema(List<int> ids)
        {
            using (var context = new KreiranjeDogadajaEntities())
            {

                Dogadaj d = (from dog in context.Dogadajs where dog.id == dogadajId select dog).FirstOrDefault();

                context.Dogadajs.Attach(d);

                Racun r = new Racun();
                r.Dogadajid = d.id;
                r.ukupno = 0;
                double suma = 0;
                foreach (var id in ids)
                {
                    Usluga u = (from usl in context.Uslugas where usl.id == id select usl).FirstOrDefault();
                    
                    context.Uslugas.Attach(u);
                    r.Uslugas.Add(u);
                    var cijena = u.cijenaUsluge ;
                    suma += (double)cijena;
                }

                r.ukupno = suma;
                r.nazivKupca = d.Organizators.FirstOrDefault().ToString();
                r.vrijeme = DateTime.Now;
                d.Racuns.Add(r);

                context.SaveChanges();

            }

            MessageBox.Show("Usluge su dodane.");

        }

        internal void AddToPdf(Bitmap bmp)
        {
            var document = new Document(iTextSharp.text.PageSize.A4.Rotate());
            

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.DefaultExt = "pdf";
            sfd.Filter = "PDF files | *.pdf";

            DialogResult result = sfd.ShowDialog();
            if(result == DialogResult.OK)
            {
                var fileStream = sfd.OpenFile();
                PdfWriter.GetInstance(document, fileStream);
                document.Open();
                
                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(bmp, System.Drawing.Imaging.ImageFormat.Bmp);
                document.Add(image);
                document.Close();

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
                ip.BackColor = System.Drawing.Color.Red;
                ip.Available = false;
                
            }

            foreach(Prostor p in available)
            {

                
                ImprovedPanel ipAvail = improvedPanels.Where(e => e.ID == p.id).FirstOrDefault();
               
                ipAvail.BackColor = System.Drawing.Color.Green;
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
                        dogadajId = newDogadaj.id;
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
