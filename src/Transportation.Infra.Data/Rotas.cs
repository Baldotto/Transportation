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
    
    public partial class Rotas
    {
        public System.Guid RotaId { get; set; }
        public string Codigo { get; set; }
        public System.Guid AreaOperacionalInicioId { get; set; }
        public System.Guid AreaOperacionalFimId { get; set; }
        public decimal Extencao { get; set; }
        public Nullable<System.Guid> AreaOperacionalFim_AreaOperacionalId { get; set; }
        public Nullable<System.Guid> AreaOperacionalInicio_AreaOperacionalId { get; set; }
    
        public virtual AreasOperacionais AreasOperacionais { get; set; }
        public virtual AreasOperacionais AreasOperacionais1 { get; set; }
    }
}
