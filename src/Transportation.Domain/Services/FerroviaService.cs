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
    public class FerroviaService : IFerroviaService
    {

        private readonly IFerroviaRepository _ferroviaRepository;

        public FerroviaService(IFerroviaRepository ferroviaRepository)
        {
            _ferroviaRepository = ferroviaRepository;
        }

        public Ferrovia Adicionar(Ferrovia ferrovia)
        {
            return _ferroviaRepository.Adicionar(ferrovia);
        }

        public Ferrovia ObterPorId(Guid id)
        {
            return _ferroviaRepository.ObterPorId(id);
        }

        public IEnumerable<Ferrovia> ObterTodos()
        {
            return _ferroviaRepository.ObterTodos();
        }

        public Ferrovia Atualizar(Ferrovia cliente)
        {
            return _ferroviaRepository.Atualizar(cliente);
        }

        public void Remover(Guid id)
        {
            _ferroviaRepository.Remover(id);
        }

        public void Dispose()
        {
            _ferroviaRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public List<Ferrovia> ListaFerrovias()
        {
            return _ferroviaRepository.ObterTodos().ToList();
        }
    }
}
