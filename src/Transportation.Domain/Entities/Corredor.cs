using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Corredor
    {

        public Corredor()
        {
            CorredorId = new Guid();
        }

        public Guid CorredorId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public Guid FerroviaId { get; set; }

        public virtual Ferrovia Ferrovia { get; set; }

    }
}
