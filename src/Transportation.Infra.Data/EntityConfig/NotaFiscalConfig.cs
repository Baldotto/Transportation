using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Infra.Data.EntityConfig
{
    public class NotaFiscalConfig : EntityTypeConfiguration<NotaFiscal>
    {

        public NotaFiscalConfig()
        {
            ToTable("NotasFiscais");
        }

    }
}
