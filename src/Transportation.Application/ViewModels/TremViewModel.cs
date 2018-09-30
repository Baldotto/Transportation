using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Application.ViewModels
{
    public class TremViewModel
    {

        public TremViewModel()
        {
            TremId = Guid.NewGuid();
        }

        [Key]
        public Guid TremId { get; set; }

        public string Prefixo { get; set; }

        public string OS { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }


    }
}
