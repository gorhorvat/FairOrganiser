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
    
    public partial class CjenikDogadaja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CjenikDogadaja()
        {
            this.Kartas = new HashSet<Karta>();
            this.TipKartes = new HashSet<TipKarte>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> vrijediOd { get; set; }
        public Nullable<System.DateTime> vrijediDo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Karta> Kartas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipKarte> TipKartes { get; set; }
    }
}
