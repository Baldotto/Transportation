using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Abastecimento
    {

        public Abastecimento()
        {

        }

        public Guid AbastecimentoId { get; set; }

        public double QuantidadeAbastecida { get; set; }

        public Guid LocomotivaId { get; set; }
        public virtual Locomotiva Locomotiva { get; set; }

        public Guid AreaOperacionalId { get; set; }
        public  AreaOperacional AreaOperacional { get; set; }

    }
}
