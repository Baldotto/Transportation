using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Domain.Entities;

namespace Transportation.Domain.Interfaces.Services
{
    public interface IClasseVagaoService : IDisposable
    {

        ClasseVagao Adicionar(ClasseVagao ferrovia);
        ClasseVagao ObterPorId(Guid id);
        IEnumerable<ClasseVagao> ObterTodos();
        ClasseVagao Atualizar(ClasseVagao cliente);
        void Remover(Guid id);
        List<ClasseVagao> ObterListaClassesVagoes();

    }
}
