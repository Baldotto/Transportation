using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Pedido
    {

        public Pedido()
        {
            PedidoId = new Guid();
        }

        public Guid PedidoId { get; set; }

        public string Codigo { get; set; }

        public Guid GrupoFluxoId { get; set; }

        public virtual GrupoFluxo GrupoFluxo { get; set; }

        public DateTime DataPedido { get; set; }

        public int QuantidadeVagoes { get; set; }

    }
}
