using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Application.ViewModels
{
    public class VagaoViewModel
    {

        public VagaoViewModel()
        {
            VagaoId = Guid.NewGuid();
        }

        [Key]
        public Guid VagaoId { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [ScaffoldColumn(false)]
        public Boolean Ativo { get; set; }

        [DisplayName("Código")]
        public String Codigo { get; set; }

        [DisplayName("Bitola")]
        public String Bitola { get; set; }
        [DisplayName("Quantidade de Eixos")]
        public int QuantidadeEixos { get; set; }
        [DisplayName("Quantidade Nominal")]
        public Double CapacidadeNominal { get; set; }
        [DisplayName("Comprimento")]
        public Double Comprimento { get; set; }

        public Double Largura { get; set; }

        public Double Altura { get; set; }
        [DisplayName("Comprimento Útil")]
        public Double ComprimentoUtil { get; set; }

        [DisplayName("Largura Útil")]
        public Double LarguraUtil { get; set; }

        [DisplayName("Volume Médio")]
        public Double VolumeMedio { get; set; }

        //Implementar vagao geminado 

        [DisplayName("Data de Fabricação")]
        public DateTime DataFabricacao { get; set; }

        public Double Tara { get; set; }

        //public Guid FerroviaProprietariaId { get; set; }
        //public virtual Ferrovia FerroviaProprietaria { get; set; }
        [ScaffoldColumn(false)]
        [DisplayName("Ferrovia Operadora")]
        public Guid FerroviaOperadoraId { get; set; }
        public virtual FerroviaViewModel FerroviaOperadora { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Serie Vagao")]
        public Guid SerieVagaoId { get; set; }
        public virtual SerieVagaoViewModel SerieVagao { get; set; }

    }
}
