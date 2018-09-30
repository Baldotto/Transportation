using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class ItemCarregamento
    {

        public ItemCarregamento()
        {
            ItemCarregamentoId = new Guid();
        }

        public Guid ItemCarregamentoId { get; set; }
        public Guid VagaoId { get; set; }
        public virtual Vagao Vagao { get; set; }

        public Guid CarregamentoId { get; set; }
        public virtual Carregamento Carregamento { get; set; }

    }
}
