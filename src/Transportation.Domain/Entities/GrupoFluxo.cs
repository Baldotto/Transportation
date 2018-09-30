using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class GrupoFluxo
    {

        public GrupoFluxo()
        {
            GrupoFluxoId = new Guid();
        }

        public Guid GrupoFluxoId { get; set; }

        public string Codigo { get; set; }
        public Guid FerroviaId { get; set; }
        public virtual  Ferrovia Ferrovia { get; set; }



    }
}
