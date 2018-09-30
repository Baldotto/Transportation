using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;

namespace Transportation.Application.Interfaces 
{
    public interface IVagaoAppService : IDisposable
    {

        VagaoViewModel Adicionar(VagaoViewModel vagaoViewModel);
        VagaoViewModel ObterPorId(Guid id);
        IEnumerable<VagaoViewModel> ObterTodos();
        VagaoViewModel Atualizar(VagaoViewModel vagaoViewModel);
        void Remover(Guid id);

   

    }
}
