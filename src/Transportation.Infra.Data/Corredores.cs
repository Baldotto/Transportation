//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Transportation.Infra.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Corredores
    {
        public System.Guid CorredorId { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public System.Guid FerroviaId { get; set; }
    
        public virtual Ferrovias Ferrovias { get; set; }
    }
}
