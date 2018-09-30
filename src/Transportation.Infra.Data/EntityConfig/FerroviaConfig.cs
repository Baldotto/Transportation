using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Infra.Data.EntityConfig
{
    public class FerroviaConfig : EntityTypeConfiguration<Ferrovia>
    {

        public FerroviaConfig()
        {
            HasKey(f => f.FerroviaId);

            Property(f => f.Codigo)
                .IsRequired()
                .HasMaxLength(4);

            Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(100);

            ToTable("Ferrovias");


        }

    }
}
