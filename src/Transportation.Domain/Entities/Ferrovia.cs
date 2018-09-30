using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Ferrovia
    {

        public Ferrovia()
        {
            FerroviaId = Guid.NewGuid();
        }
        
        public Guid FerroviaId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        public DateTime DataCadastro { get; set; }

        //public virtual Vagao Vagao { get; set; } //Propriedade logica para o Entity Framework

    }
}
