using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class AreaOperacional
    {

        public AreaOperacional()
        {
            AreaOperacionalId = new Guid();
        }

        public Guid AreaOperacionalId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public Guid FerroviaOperadoraId { get; set; }
        public virtual Ferrovia FerroviaOperadora { get; set; }
    }
}
