//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionLegalite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class repost
    {
        public int id { get; set; }
        public Nullable<int> idpost { get; set; }
        public string Contenido { get; set; }
        public Nullable<System.DateTime> FechaCreación { get; set; }
        public string idasesor { get; set; }
    
        public virtual post post { get; set; }
    }
}
