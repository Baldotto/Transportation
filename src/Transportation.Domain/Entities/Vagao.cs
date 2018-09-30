using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Domain.Entities
{
    public class Vagao
    {

        public Vagao()
        {
            VagaoId = Guid.NewGuid();
        }

        public Guid VagaoId { get; set; }

        public DateTime DataCadastro { get; set; }

        public Boolean Ativo { get; set; }

        public String Codigo { get; set; }

        public String Bitola { get; set; }

        public int QuantidadeEixos { get; set; }

        public Double CapacidadeNominal { get; set; }

        public Double Comprimento { get; set; }

        public Double Largura { get; set; }

        public Double Altura { get; set; }

        public Double ComprimentoUtil { get; set; }

        public Double LarguraUtil { get; set; }

        public Double VolumeMedio  { get; set; }

        //Implementar vagao geminado 

        public DateTime DataFabricacao { get; set; }

        public Double Tara { get; set; }

        //public Guid FerroviaProprietariaId { get; set; }
        //public virtual Ferrovia FerroviaProprietaria { get; set; }
        public Guid FerroviaOperadoraId { get; set; }
        public virtual Ferrovia FerroviaOperadora { get; set; }

        public Guid SerieVagaoId { get; set; }
        public virtual SerieLocomotiva SerieVagao { get; set; }

        //public Guid FerroviaConcesseionariaId { get; set; }
        //public virtual Ferrovia FerroviaConcesseionaria { get; set; }

        //public String Categoria { get; set; }




    }
}
