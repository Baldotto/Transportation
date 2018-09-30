using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Infra.Data.EntityConfig
{
    class ComposicaoLocomotivaConfig : EntityTypeConfiguration<ComposicaoLocomotiva>
    {

        public ComposicaoLocomotivaConfig()
        {
            HasKey(c => c.ComposicaoLocomotivaId);

            ToTable("ComposicoesLocomotivas");
        }
    }
}
