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
    
    public partial class Dostava
    {
        public int id_dostava { get; set; }
        public int id_korisnik { get; set; }
        public int id_narudzba { get; set; }
        public string adresa_dostave { get; set; }
        public string broj_telefona { get; set; }
        public double cijena_dostave { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Narudzba Narudzba { get; set; }
    }
}