using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;

namespace Transportation.Application.Interfaces
{
    public interface ITremAppService : IDisposable
    {

        TremViewModel Adicionar(TremViewModel tremViewModel);
        TremViewModel ObterPorId(Guid id);
        IEnumerable<TremViewModel> ObterTodos();
        TremViewModel Atualizar(TremViewModel tremViewModel);
        void Remover(Guid id);

    }
}
