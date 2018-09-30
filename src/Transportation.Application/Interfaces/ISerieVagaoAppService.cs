using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;
using Transportation.Domain.Entities;

namespace Transportation.Application.Interfaces
{
    public interface ISerieVagaoAppService : IDisposable
    {

        SerieVagaoViewModel Adicionar(SerieVagaoViewModel serieVagaoViewModel);
        SerieVagaoViewModel ObterPorId(Guid id);
        IEnumerable<SerieVagaoViewModel> ObterTodos();
        SerieVagaoViewModel Atualizar(SerieVagaoViewModel serieVagaoViewModel);
        void Remover(Guid id);
        List<ClasseVagaoViewModel> ListaClassesVagoes();
        List<SerieVagaoViewModel> ListaSerieVagoes();

    }
}
