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
    
    public partial class ComposicoesLocomotivas
    {
        public System.Guid ComposicaoLocomotivaId { get; set; }
        public System.Guid ComposicaoId { get; set; }
        public System.Guid LocomotivaId { get; set; }
    
        public virtual Composicoes Composicoes { get; set; }
        public virtual Locomotivas Locomotivas { get; set; }
    }
}
