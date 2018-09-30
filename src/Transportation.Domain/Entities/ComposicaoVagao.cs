using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class ComposicaoVagao
    {

        public ComposicaoVagao()
        {
            ComposicaoVagaoId = Guid.NewGuid();
        }

        public Guid ComposicaoVagaoId { get; set; }

        public virtual Composicao Composicao { get; set; }
        public Guid ComposicaoId { get; set; }

        public virtual Vagao Vagao { get; set; }
        public Guid VagaoId { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
