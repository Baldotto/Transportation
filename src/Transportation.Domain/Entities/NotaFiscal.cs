using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class NotaFiscal
    {

        public NotaFiscal()
        {
            NotaFiscalId = new Guid();
        }

        public Guid NotaFiscalId { get; set; }

        public string Serie { get; set; }

        public string Numero { get; set; }



    }
}
