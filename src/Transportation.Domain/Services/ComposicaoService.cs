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
    public class ComposicaoService : IComposicaoService
    {

        private readonly IComposicaoRepository _composicaoRepository;

        public ComposicaoService(IComposicaoRepository composicaoRepository)
        {
            _composicaoRepository = composicaoRepository;
        }

        public Composicao Adicionar(Composicao composicao)
        {
            return _composicaoRepository.Adicionar(composicao);
        }

        public Composicao Atualizar(Composicao composicao)
        {
            return _composicaoRepository.Atualizar(composicao);
        }

        public void Dispose()
        {
            _composicaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Composicao ObterPorId(Guid id)
        {
            return _composicaoRepository.ObterPorId(id);
        }

        public Composicao ObterPorTremId(Guid id)
        {
            return _composicaoRepository.ObterPorTremId(id);
        }

        public IEnumerable<Composicao> ObterTodos()
        {
            return _composicaoRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _composicaoRepository.Remover(id);
        }
    }
}
