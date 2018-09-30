using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Interfaces.Services
{
    public interface IComposicaoService : IDisposable
    {

        Composicao Adicionar(Composicao composicao);
        Composicao ObterPorId(Guid id);
        IEnumerable<Composicao> ObterTodos();
        Composicao Atualizar(Composicao composicao);
        void Remover(Guid id);
        Composicao ObterPorTremId(Guid id);

    }
}
