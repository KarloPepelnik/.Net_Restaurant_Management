//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramskoIntenjerstvo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jelo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jelo()
        {
            this.Jelo_sadrzi = new HashSet<Jelo_sadrzi>();
            this.Narucuje = new HashSet<Narucuje>();
            this.Stavke_racuna = new HashSet<Stavke_racuna>();
            this.Meni = new HashSet<Meni>();
        }
    
        public int id_jelo { get; set; }
        public int id_kategorija { get; set; }
        public string naziv_jela { get; set; }
        public double cijena { get; set; }
    
        public virtual Kategorija Kategorija { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Jelo_sadrzi> Jelo_sadrzi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narucuje> Narucuje { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stavke_racuna> Stavke_racuna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meni> Meni { get; set; }
    }
}
