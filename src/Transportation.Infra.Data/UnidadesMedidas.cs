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
    
    public partial class UnidadesMedidas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UnidadesMedidas()
        {
            this.Fluxos = new HashSet<Fluxos>();
        }
    
        public System.Guid UnidadeMedidaId { get; set; }
        public string Codico { get; set; }
        public string Descricao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fluxos> Fluxos { get; set; }
    }
}
