using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;

namespace Transportation.Application.Interfaces
{
    public interface IComposicaoAppService : IDisposable
    {
        ComposicaoViewModel Adicionar(ComposicaoViewModel composicaoViewModel);
        ComposicaoViewModel ObterPorId(Guid id);
        IEnumerable<ComposicaoViewModel> ObterTodos();
        ComposicaoViewModel Atualizar(ComposicaoViewModel composicaoViewModel);
        void Remover(Guid id);
        ComposicaoViewModel ObterPorTremId(Guid id);

    }
}
