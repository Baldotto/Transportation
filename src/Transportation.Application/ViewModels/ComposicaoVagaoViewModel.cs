using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Application.ViewModels
{
    public class ComposicaoVagaoViewModel
    {

        public ComposicaoVagaoViewModel()
        {
            ComposicaoVagaoId = Guid.NewGuid();
        }

        [Key]
        public Guid ComposicaoVagaoId { get; set; }

        public virtual ComposicaoViewModel Composicao { get; set; }
        public Guid ComposicaoId { get; set; }

        public virtual VagaoViewModel Vagao { get; set; }
        public Guid VagaoId { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
