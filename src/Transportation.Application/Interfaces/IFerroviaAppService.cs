using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;

namespace Transportation.Application.Interfaces
{
    public interface IFerroviaAppService : IDisposable
    {

        FerroviaViewModel Adicionar(FerroviaViewModel ferroviaViewModel);
        FerroviaViewModel ObterPorId(Guid id);
        IEnumerable<FerroviaViewModel> ObterTodos();
        FerroviaViewModel Atualizar(FerroviaViewModel clienteViewModel);
        void Remover(Guid id);
        List<FerroviaViewModel> ListaFerrovias();

    }
}
