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
    
    public partial class ClassesVagoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClassesVagoes()
        {
            this.SeriesVagoes = new HashSet<SeriesVagoes>();
        }
    
        public System.Guid ClasseVagaoId { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public System.DateTime DataCadastro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeriesVagoes> SeriesVagoes { get; set; }
    }
}