using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Infra.Data.EntityConfig
{
    class SerieVagaoConfig : EntityTypeConfiguration<SerieVagao>
    {

        public SerieVagaoConfig()
        {
            HasKey(f => f.SerieVagaoId);

            Property(f => f.Codigo)
                .IsRequired()
                .HasMaxLength(3);

            Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(30);


            // HasOptional()
            HasRequired(e => e.ClasseVagao)
                .WithMany()
                .HasForeignKey(e => e.ClasseVagaoId);

            ToTable("SeriesVagoes");
        }
            
    }
}
