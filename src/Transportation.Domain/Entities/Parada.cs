using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Parada
    {

        public Parada()
        {
            ParadaId = new Guid();
        }

        public Guid ParadaId { get; set; }

        public DateTime Datainicio { get; set; }

        public DateTime DataFim { get; set; }

        public Guid AreaOperacionalId { get; set; }
        public virtual AreaOperacional AreaOperacional { get; set; }

    }
}
