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
    
    public partial class Narucuje
    {
        public int id_narudzba { get; set; }
        public int id_jelo { get; set; }
        public double kolicina { get; set; }
    
        public virtual Jelo Jelo { get; set; }
        public virtual Narudzba Narudzba { get; set; }
    }
}