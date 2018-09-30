using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Transportation.Infra.Data.EntityConfig
{
    public class ClasseVagaoConfig : EntityTypeConfiguration<ClasseVagao>
    {

        public ClasseVagaoConfig()
        {
            HasKey(f => f.ClasseVagaoId);

            Property(f => f.Codigo)
                .IsRequired()
                .HasMaxLength(1);

            Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(20);

            ToTable("ClassesVagoes");
        }

    }
}
