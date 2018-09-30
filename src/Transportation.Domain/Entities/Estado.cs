using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Estado
    {

        public Estado()
        {
            EstadoId = Guid.NewGuid();
        }

        public Guid EstadoId { get; set; }

        public string Sigla { get; set; }

        public string Nome { get; set; }

    }
}
