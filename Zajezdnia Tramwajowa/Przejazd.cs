//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zajezdnia_Tramwajowa
{
    using System;
    using System.Collections.Generic;
    
    public partial class Przejazd
    {
        public int IDPrzejazdu { get; set; }
        public int IDMaszynisty { get; set; }
        public int IDTramwaju { get; set; }
        public int IDTrasy { get; set; }
        public System.DateTime CzasOdjazdu { get; set; }
        public byte[] RowVersion { get; set; }
    
        public virtual Maszynista Maszynista { get; set; }
        public virtual Tramwaj Tramwaj { get; set; }
        public virtual Trasa Trasa { get; set; }
    }
}
