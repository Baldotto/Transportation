using System;
using System.ComponentModel.DataAnnotations;

namespace Transportation.Application.ViewModels
{
    public class ClasseVagaoViewModel
    {
        public ClasseVagaoViewModel()
        {
            ClasseVagaoId = Guid.NewGuid();
        }

        [Key]
        public Guid ClasseVagaoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(1, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(1, ErrorMessage = "Mínimo {0} caracteres")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Numero")]
        [MaxLength(20, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }
    }
}
