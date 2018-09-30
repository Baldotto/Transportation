using System;
using System.Collections.Generic;

namespace Transportation.Domain.Entities
{
    public class SerieVagao
    {

        public SerieVagao()
        {
            SerieVagaoId = Guid.NewGuid();
            
        }

        public Guid SerieVagaoId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }
   
        public Guid ClasseVagaoId { get; set; }

        public virtual ClasseVagao ClasseVagao { get; set; }

        public DateTime DataCadastro { get; set; }

       
    }
}
