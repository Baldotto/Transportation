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
    public class ClasseVagaoService : IClasseVagaoService
    {

        private readonly IClasseVagaoRepository _classeVagaoRepository;

        public ClasseVagaoService(IClasseVagaoRepository classeVagaoRepository)
        {
            _classeVagaoRepository = classeVagaoRepository;
        }

        public ClasseVagao Adicionar(ClasseVagao classeVagao)
        {
            return _classeVagaoRepository.Adicionar(classeVagao);
        }

        public ClasseVagao ObterPorId(Guid id)
        {
            return _classeVagaoRepository.ObterPorId(id);
        }

        public IEnumerable<ClasseVagao> ObterTodos()
        {
            return _classeVagaoRepository.ObterTodos();
        }

        public ClasseVagao Atualizar(ClasseVagao classeVagao)
        {
            return _classeVagaoRepository.Atualizar(classeVagao);
        }

        public void Remover(Guid id)
        {
            _classeVagaoRepository.Remover(id);
        }

        public void Dispose()
        {
            _classeVagaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }

        public List<ClasseVagao> ObterListaClassesVagoes()
        {
            return _classeVagaoRepository.ObterTodos().ToList();
        }

    }
}
