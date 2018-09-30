using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class FolhaEspecificacaoVagao
    {

        public FolhaEspecificacaoVagao()
        {
            FolhaEspecificacaoVagaoId = Guid.NewGuid();
        }

        public Guid FolhaEspecificacaoVagaoId { get; set; }

        public Guid SerieVagaoId { get; set; }

        public Double Tara { get; set; }

        public Double VolumeMedio { get; set; }

        public Double Comprimento { get; set; }

        public Double Largura { get; set; }

        public Double Altura { get; set; }

        public Double ComprimentoUtil { get; set; }

        public Double LarguraUtil { get; set; }

        public Double AlturaUtil { get; set; }

        public DateTime DataCadastro { get; set; }
    }
}
