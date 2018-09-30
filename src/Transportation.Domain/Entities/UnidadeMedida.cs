using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class UnidadeMedida
    {

        public UnidadeMedida()
        {
            UnidadeMedidaId = new Guid();
        }

        public Guid UnidadeMedidaId { get; set; }

        public string Codico { get; set; }

        public string Descricao { get; set; }

    }
}
