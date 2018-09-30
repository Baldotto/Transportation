using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Interfaces.Services
{
    public interface IComposicaoVagaoService : IDisposable
    {

        ComposicaoVagao Adicionar(ComposicaoVagao composicao);
        ComposicaoVagao ObterPorId(Guid id);
        IEnumerable<ComposicaoVagao> ObterTodos();
        ComposicaoVagao Atualizar(ComposicaoVagao composicao);
        ComposicaoVagao ObterPorComposicaoId(Guid id);
        void Remover(Guid id);

    }
}
