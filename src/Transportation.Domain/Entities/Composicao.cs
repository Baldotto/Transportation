using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Composicao
    {

        public Composicao()
        {
            ComposicaoId = Guid.NewGuid();
        }

        public Guid ComposicaoId { get; set; }

        public bool IndicadorAtivo { get; set; }

        public Guid TremId { get; set; }

        public virtual Trem Trem { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
