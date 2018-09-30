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
    
    public partial class Locomotivas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Locomotivas()
        {
            this.Abastecimentos = new HashSet<Abastecimentos>();
            this.ComposicoesLocomotivas = new HashSet<ComposicoesLocomotivas>();
        }
    
        public System.Guid LocomotivaId { get; set; }
        public string Codigo { get; set; }
        public System.Guid FerroviaProprietariaId { get; set; }
        public System.Guid SerieLocomotivaId { get; set; }
        public Nullable<System.Guid> FerroviaProprietaria_FerroviaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abastecimentos> Abastecimentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComposicoesLocomotivas> ComposicoesLocomotivas { get; set; }
        public virtual Ferrovias Ferrovias { get; set; }
        public virtual SeriesLocomotivas SeriesLocomotivas { get; set; }
    }
}
