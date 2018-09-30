using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class SerieCarregamento
    {

        public SerieCarregamento()
        {
            SerieCarregamentoId = new Guid();
        }

        public Guid SerieCarregamentoId { get; set; }

        public string Codigo { get; set; }

        public Guid FerroviaId { get; set; }

        public Guid EstadoId { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Ferrovia Ferrovia { get; set; }



    }
}
