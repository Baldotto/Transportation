using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;
using Transportation.Domain.Interfaces.Services;
using Transportation.Domain.Repository;

namespace Transportation.Domain.Services
{
    public class VagaoService : IVagaoService
    {

        private readonly IVagaoRepository _vagaoRepository;

        public VagaoService(IVagaoRepository vagaoRepository)
        {
            _vagaoRepository = vagaoRepository;
        }
        public Vagao Adicionar(Vagao vagao)
        {
            return _vagaoRepository.Adicionar(vagao);
        }

        public Vagao Atualizar(Vagao vagao)
        {
            return _vagaoRepository.Atualizar(vagao);
        }

        public void Dispose()
        {
            _vagaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }


        public Vagao ObterPorId(Guid id)
        {
            return _vagaoRepository.ObterPorId(id);
        }

        public IEnumerable<Vagao> ObterTodos()
        {
            return _vagaoRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _vagaoRepository.Remover(id);
        }
    }
}
