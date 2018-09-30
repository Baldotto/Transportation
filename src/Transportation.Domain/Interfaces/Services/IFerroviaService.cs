using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Interfaces.Services
{
    public interface IFerroviaService : IDisposable
    {

        Ferrovia Adicionar(Ferrovia ferrovia);
        Ferrovia ObterPorId(Guid id);
        IEnumerable<Ferrovia> ObterTodos();
        Ferrovia Atualizar(Ferrovia cliente);
        void Remover(Guid id);

        List<Ferrovia> ListaFerrovias();

    }
}
