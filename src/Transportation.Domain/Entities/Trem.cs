using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Trem
    {

        public Trem()
        {
            TremId = new Guid();
        }

        public Guid TremId { get; set; }

        public string Prefixo { get; set; }

        public string OS { get; set; }

        public DateTime DataCadastro { get; set; }




    }
}
