//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Zaposlenik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zaposlenik()
        {
            this.Racuns = new HashSet<Racun>();
        }
    
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string oib { get; set; }
        public string adresa { get; set; }
        public string brojTelefona { get; set; }
        public string email { get; set; }
        public string tipZaposlenika { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racuns { get; set; }
    }
}
