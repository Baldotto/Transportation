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
    
    public partial class Clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes()
        {
            this.Enderecos = new HashSet<Enderecos>();
            this.Fluxos = new HashSet<Fluxos>();
        }
    
        public System.Guid ClienteId { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string CNPJ { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Enderecos> Enderecos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fluxos> Fluxos { get; set; }
    }
}