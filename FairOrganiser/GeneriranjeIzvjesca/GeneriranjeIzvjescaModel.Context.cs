﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneriranjeIzvjesca
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GeneriranjeIzvjescaEntities : DbContext
    {
        public GeneriranjeIzvjescaEntities()
            : base("name=GeneriranjeIzvjescaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dogadaj> Dogadajs { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<Zaposlenik> Zaposleniks { get; set; }
    }
}
