﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EvidencijaOrganizatora
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class evidencijaOrganizatoraEntities : DbContext
    {
        public evidencijaOrganizatoraEntities()
            : base("name=evidencijaOrganizatoraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Dogadaj> Dogadajs { get; set; }
        public virtual DbSet<Organizator> Organizators { get; set; }
        public virtual DbSet<TipOrganizatora> TipOrganizatoras { get; set; }
        public virtual DbSet<tse_dog_org> tse_dog_org { get; set; }
    }
}
