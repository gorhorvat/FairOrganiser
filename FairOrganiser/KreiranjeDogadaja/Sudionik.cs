//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KreiranjeDogadaja
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sudionik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sudionik()
        {
            this.Dogadajs = new HashSet<Dogadaj>();
        }
    
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string medijskaKuca { get; set; }
        public string telefon { get; set; }
        public string email { get; set; }
        public string dogadaj { get; set; }
        public string akreditacija { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dogadaj> Dogadajs { get; set; }
    }
}
