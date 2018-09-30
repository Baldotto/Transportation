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
    public class TremService : ITremService
    {


        private readonly ITremRepository _tremRepository;

        public TremService(ITremRepository tremRepository)
        {
            _tremRepository = tremRepository;
        }


        public Trem Adicionar(Trem trem)
        {
            return _tremRepository.Adicionar(trem);
        }

        public Trem Atualizar(Trem trem)
        {
            return _tremRepository.Atualizar(trem);
        }

        public void Dispose()
        {
            _tremRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Trem ObterPorId(Guid id)
        {
            return _tremRepository.ObterPorId(id);
        }

        public IEnumerable<Trem> ObterTodos()
        {
            return _tremRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _tremRepository.Remover(id);
        }
    }
}
