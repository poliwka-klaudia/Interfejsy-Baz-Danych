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
    
    public partial class Klient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klient()
        {
            this.Zamowienie = new HashSet<Zamowienie>();
        }
    
        public long idKlient { get; set; }
        public string NazwaFirmy { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public string Email { get; set; }
        public string NrTelefonu { get; set; }
        public string NiP { get; set; }
        public string Osoba { get; set; }
        public string NrTelefonuOsoby { get; set; }
        public string Ulica { get; set; }
        public string Numer { get; set; }
        public string KodPocztowy { get; set; }
        public string Miasto { get; set; }
        public string TypKlienta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}
