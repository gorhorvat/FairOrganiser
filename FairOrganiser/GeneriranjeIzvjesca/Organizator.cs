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
    
    public partial class Organizator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organizator()
        {
            this.tse_dog_org = new HashSet<tse_dog_org>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public string oib { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
        public string brojTelefona { get; set; }
        public Nullable<int> TipOrganizatoraid { get; set; }
    
        public virtual TipOrganizatora TipOrganizatora { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tse_dog_org> tse_dog_org { get; set; }
    }
}
