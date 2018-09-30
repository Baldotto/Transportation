using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Interfaces.Services
{
    public interface ITremService : IDisposable
    {

        Trem Adicionar(Trem trem);
        Trem ObterPorId(Guid id);
        IEnumerable<Trem> ObterTodos();
        Trem Atualizar(Trem trem);
        void Remover(Guid id);

    }
}
