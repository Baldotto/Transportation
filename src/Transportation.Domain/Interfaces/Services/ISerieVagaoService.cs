using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Interfaces.Services
{
    public interface ISerieVagaoService : IDisposable
    {

        SerieVagao Adicionar(SerieVagao serieVagao);
        SerieVagao ObterPorId(Guid id);
        IEnumerable<SerieVagao> ObterTodos();
        SerieVagao Atualizar(SerieVagao serieVagao);
        void Remover(Guid id);
        List<SerieVagao> ListaSerieVagoes();


    }
}
