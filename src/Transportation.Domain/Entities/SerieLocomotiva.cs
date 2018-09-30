using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class SerieLocomotiva
    {

        public SerieLocomotiva()
        {
            SerieLocomotivaId = Guid.NewGuid();

        }

        public Guid SerieLocomotivaId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
