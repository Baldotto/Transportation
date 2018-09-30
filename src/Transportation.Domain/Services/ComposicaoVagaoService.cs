using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using Transportation.Domain.Interfaces.Repository;
using Transportation.Domain.Interfaces.Services;

namespace Transportation.Domain.Services
{
    public class ComposicaoVagaoService : IComposicaoVagaoService
    {

        private readonly IComposicaoVagaoRepository _composicaoVagaoRepository;

        public ComposicaoVagaoService(IComposicaoVagaoRepository composicaoVagaoRepository)
        {
            _composicaoVagaoRepository = composicaoVagaoRepository;
        }

        public ComposicaoVagao Adicionar(ComposicaoVagao composicao)
        {
            return _composicaoVagaoRepository.Adicionar(composicao);
        }

        public ComposicaoVagao Atualizar(ComposicaoVagao composicao)
        {
            return _composicaoVagaoRepository.Atualizar(composicao);
        }

        public void Dispose()
        {
            _composicaoVagaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public ComposicaoVagao ObterPorComposicaoId(Guid id)
        {
            return _composicaoVagaoRepository.ObterPorComposicaoId(id);
        }

        public ComposicaoVagao ObterPorId(Guid id)
        {
            return _composicaoVagaoRepository.ObterPorId(id);
        }

        public IEnumerable<ComposicaoVagao> ObterTodos()
        {
            return _composicaoVagaoRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _composicaoVagaoRepository.Remover(id);
        }
    }
}
