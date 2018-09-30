using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Rota
    {

        public Rota()
        {
            RotaId = new Guid();
        }

        public Guid RotaId { get; set; }

        public string Codigo { get; set; }

        public Guid AreaOperacionalInicioId { get; set; }

        public Guid AreaOperacionalFimId { get; set; }

        public virtual AreaOperacional AreaOperacionalInicio { get; set; }

        public virtual AreaOperacional AreaOperacionalFim { get; set; }

        public decimal Extencao { get; set; }

    }
}
