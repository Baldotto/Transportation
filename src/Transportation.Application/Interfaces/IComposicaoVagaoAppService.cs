using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;

namespace Transportation.Application.Interfaces
{
    public interface IComposicaoVagaoAppService : IDisposable 
    {

        ComposicaoVagaoViewModel Adicionar(ComposicaoVagaoViewModel composicaoViewModel);
        ComposicaoVagaoViewModel ObterPorId(Guid id);
        IEnumerable<ComposicaoVagaoViewModel> ObterTodos();
        ComposicaoVagaoViewModel Atualizar(ComposicaoVagaoViewModel composicaoViewModel);
        void Remover(Guid id);
        ComposicaoVagaoViewModel ObterPorComposicaoId(Guid id);


    }
}
