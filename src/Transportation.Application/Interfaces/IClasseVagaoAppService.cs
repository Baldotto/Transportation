using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;

namespace Transportation.Application.Interfaces
{
    public interface IClasseVagaoAppService : IDisposable
    {

        ClasseVagaoViewModel Adicionar(ClasseVagaoViewModel classeVagaoViewModel);
        ClasseVagaoViewModel ObterPorId(Guid id);
        IEnumerable<ClasseVagaoViewModel> ObterTodos();
        ClasseVagaoViewModel Atualizar(ClasseVagaoViewModel classeVagaoViewModel);
        void Remover(Guid id);
        List<ClasseVagaoViewModel> ObterListaClassesVagoes();

    }
}
