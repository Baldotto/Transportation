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
    
    public partial class Movimentacoes
    {
        public System.Guid MovimentacaoId { get; set; }
        public System.DateTime DataChegada { get; set; }
        public System.DateTime DataSaida { get; set; }
        public System.Guid AreaOperacionalId { get; set; }
    
        public virtual AreasOperacionais AreasOperacionais { get; set; }
    }
}