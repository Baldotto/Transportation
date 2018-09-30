using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Carregamento
    {

        public Carregamento()
        {
            CarregamentoId = new Guid();
        }

        public Guid CarregamentoId { get; set; }


        public Guid MercadoriaId { get; set; }

        public virtual Mercadoria Mercadoria { get; set; }

        public decimal QuantidadeCarregada { get; set; }

        public Guid NotaFiscalId { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }


    }
}
