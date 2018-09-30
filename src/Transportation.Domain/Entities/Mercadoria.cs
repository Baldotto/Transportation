using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Mercadoria
    {

        public Mercadoria()
        {
            MercadoriaId = new Guid();
        }


        public Guid MercadoriaId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

    }
}
