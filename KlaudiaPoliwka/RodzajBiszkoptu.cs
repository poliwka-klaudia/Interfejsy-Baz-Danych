//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KlaudiaPoliwka
{
    using System;
    using System.Collections.Generic;
    
    public partial class RodzajBiszkoptu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RodzajBiszkoptu()
        {
            this.Biszkopt = new HashSet<Biszkopt>();
        }
    
        public long idRodzajBiszkoptu { get; set; }
        public string Rodzaj { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Biszkopt> Biszkopt { get; set; }
    }
}
