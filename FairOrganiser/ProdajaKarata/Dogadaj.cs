//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Dogadaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dogadaj()
        {
            this.Kartas = new HashSet<Karta>();
            this.Racuns = new HashSet<Racun>();
            this.tse_dog_org = new HashSet<tse_dog_org>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public Nullable<System.DateTime> datumOd { get; set; }
        public Nullable<System.DateTime> datumDo { get; set; }
        public Nullable<double> cijenaKarte { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karta> Kartas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racuns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tse_dog_org> tse_dog_org { get; set; }
    }
}
