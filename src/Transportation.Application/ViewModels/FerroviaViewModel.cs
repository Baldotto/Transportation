using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.Application.ViewModels
{
    public class FerroviaViewModel
    {

        public FerroviaViewModel()
        {
            FerroviaId = Guid.NewGuid();
        }

        [Key]
        public Guid FerroviaId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(4, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }


    }
}
