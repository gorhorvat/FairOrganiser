﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProdajaKarata
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProdajaKarataEntities : DbContext
    {
        public ProdajaKarataEntities()
            : base("name=ProdajaKarataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CjenikDogadaja> CjenikDogadajas { get; set; }
        public virtual DbSet<Dogadaj> Dogadajs { get; set; }
        public virtual DbSet<Karta> Kartas { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<Zaposlenik> Zaposleniks { get; set; }
        public virtual DbSet<TipKarte> TipKartes { get; set; }
    }
}
