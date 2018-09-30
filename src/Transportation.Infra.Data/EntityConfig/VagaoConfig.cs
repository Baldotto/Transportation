using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Transportation.Infra.Data.EntityConfig
{
    public class VagaoConfig : EntityTypeConfiguration<Vagao>
    {

        public VagaoConfig()
        {
            HasKey(f => f.VagaoId);

            Property(f => f.Codigo)
                .IsRequired()
                .HasMaxLength(3);

            Property(f => f.Codigo)
                .IsRequired()
                .HasMaxLength(7);

            Property(f => f.Bitola)
               .IsRequired()
               .HasMaxLength(20);

            Property(f => f.QuantidadeEixos)
               .IsRequired();

            Property(f => f.CapacidadeNominal)
               .IsRequired();

            Property(f => f.Comprimento)
               .IsRequired();

            Property(f => f.Largura)
              .IsRequired();

            Property(f => f.ComprimentoUtil)
               .IsRequired();

            Property(f => f.LarguraUtil)
               .IsRequired();

            Property(f => f.Altura)
               .IsRequired();

            Property(f => f.VolumeMedio)
               .IsRequired();

            Property(f => f.DataFabricacao)
                           .IsRequired();

            Property(f => f.Tara)
                           .IsRequired();

            // HasOptional()
            HasRequired(e => e.FerroviaOperadora)
                .WithMany()
                .HasForeignKey(e => e.FerroviaOperadoraId);

            // HasOptional()
            HasRequired(e => e.SerieVagao)
                .WithMany()
                .HasForeignKey(e => e.SerieVagaoId);

            ToTable("Vagoes");
        }

    }
}
