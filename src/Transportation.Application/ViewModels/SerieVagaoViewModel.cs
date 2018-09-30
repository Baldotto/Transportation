using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Application.ViewModels
{
    public class SerieVagaoViewModel
    {

        public SerieVagaoViewModel()
        {
            SerieVagaoId = Guid.NewGuid();
        }

        [Key]
        public Guid SerieVagaoId { get; set; }

 
        public string Codigo { get; set; }

        public string Descricao { get; set; }


        [ScaffoldColumn(false)]
        [DisplayName("Classe")]
        public Guid ClasseVagaoId { get; set; }
        public virtual ClasseVagaoViewModel ClasseVagao { get; set; }

    }
}
