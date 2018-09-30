using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Interfaces.Services
{
    public interface IVagaoService : IDisposable 
    {

        Vagao Adicionar(Vagao vagao);
        Vagao ObterPorId(Guid id);
        IEnumerable<Vagao> ObterTodos();
        Vagao Atualizar(Vagao vagao);
        void Remover(Guid id);

    }
}
