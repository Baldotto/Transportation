using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Application.ViewModels
{
    public class ComposicaoViewModel
    {

        public ComposicaoViewModel()
        {
            ComposicaoId = Guid.NewGuid();
        }

        [Key]
        public Guid ComposicaoId { get; set; }

        public bool IndicadorAtivo { get; set; }

        public Guid TremId { get; set; }
        public virtual TremViewModel Trem { get; set; }

        public DateTime DataCadastro { get; set; }

    }
}
