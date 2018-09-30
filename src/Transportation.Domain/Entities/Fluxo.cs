using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Fluxo
    {

        public Fluxo()
        {

            FluxoId = new Guid();
                
        }

        public Guid FluxoId { get; set; }
        public string Codigo { get; set; }

        public Guid OrigemId { get; set; }
        public virtual AreaOperacional Origem { get; set; }

        public Guid DestinoId { get; set; }
        public virtual AreaOperacional Destino { get; set; }

        public Guid ClienteCorrentistaId { get; set; }
        public virtual Cliente ClienteCorrentista { get; set; }

        public Guid MercadoriaId { get; set; }
        public virtual Mercadoria Mercadoria { get; set; }

        public Guid UnidadeMedidaId { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }

    }
}
