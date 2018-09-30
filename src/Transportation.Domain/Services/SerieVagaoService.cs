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
    public class SerieVagaoService : ISerieVagaoService
    {

        private readonly ISerieVagaoRepository _serieVagaoRepository;

        public SerieVagaoService(ISerieVagaoRepository serieVagaoRepository)
        {
            _serieVagaoRepository = serieVagaoRepository;
        }

        public SerieVagao Adicionar(SerieVagao serieVagao)
        {
            return _serieVagaoRepository.Adicionar(serieVagao);
        }

        public SerieVagao Atualizar(SerieVagao serieVagao)
        {
            return _serieVagaoRepository.Atualizar(serieVagao);
        }

        public void Dispose()
        {
            _serieVagaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public List<SerieVagao> ListaSerieVagoes()
        {
            return _serieVagaoRepository.ObterTodos().ToList();
        }

        public SerieVagao ObterPorId(Guid id)
        {
            return _serieVagaoRepository.ObterPorId(id);
        }

        public IEnumerable<SerieVagao> ObterTodos()
        {
            // Implementar aqui a logica para trazer as classes associadas.
             return _serieVagaoRepository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            _serieVagaoRepository.Remover(id);
        }
    }
}
