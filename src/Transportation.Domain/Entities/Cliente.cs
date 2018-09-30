using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Cliente
    {

        public Cliente()
        {
            ClienteId = new Guid();
        }

        public Guid ClienteId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public string CNPJ { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }



    }
}
