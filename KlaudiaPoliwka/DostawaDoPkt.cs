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
    
    public partial class DostawaDoPkt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DostawaDoPkt()
        {
            this.Zamowienie = new HashSet<Zamowienie>();
        }
    
        public long idDostawaDoPkt { get; set; }
        public string ulica { get; set; }
        public string nrdomu { get; set; }
        public string nrmieszkania { get; set; }
        public string miejscowosc { get; set; }
        public string nrtelefonu { get; set; }
        public string godzinyotwarcia { get; set; }
        public string nazwa { get; set; }
        public string kodpocztowy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
