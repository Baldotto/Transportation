using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Application.ViewModels
{
    public class AreaOperacionalViewModel
    {

        public AreaOperacionalViewModel()
        {
            AreaOperacionalId = new Guid();
        }

        public Guid AreaOperacionalId { get; set; }

        public string Codigo { get; set; }

        public string Descricao { get; set; }

        [ScaffoldColumn(false)]
        public Guid FerroviaOperadoraId { get; set; }
        public virtual FerroviaViewModel FerroviaOperadora { get; set; }

    }
}
