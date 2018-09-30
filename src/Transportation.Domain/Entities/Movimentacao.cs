using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Movimentacao
    {

        public Movimentacao()
        {
            MovimentacaoId = new Guid();
        }


        public Guid MovimentacaoId { get; set; }

        public DateTime DataChegada { get; set; }

        public DateTime DataSaida { get; set; }

        public Guid AreaOperacionalId { get; set; }
        public virtual AreaOperacional AreaOperacional { get; set; }

    }
}
