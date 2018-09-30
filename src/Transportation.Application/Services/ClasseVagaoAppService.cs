using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.Interfaces;
using Transportation.Application.ViewModels;
using Transportation.Domain.Entities;
using Transportation.Domain.Interfaces.Services;
using Transportation.Infra.Data.Interfaces;

namespace Transportation.Application.Services
{
    public class ClasseVagaoAppService : AppService, IClasseVagaoAppService
    {


        private readonly IClasseVagaoService _claseVagaoService;
        public ClasseVagaoAppService(IClasseVagaoService claseVagaoService, IUnitOfWork uow) : base(uow)
        {

            _claseVagaoService = claseVagaoService;

        }

        public ClasseVagaoViewModel Adicionar(ClasseVagaoViewModel classeVagaoViewModel)
        {

            var ClasseVagao = Mapper.Map<ClasseVagaoViewModel, ClasseVagao>(classeVagaoViewModel);

            _claseVagaoService.Adicionar(ClasseVagao);
            // add pedido
            // solicitar NF

            // Verificar se todas as regras de negocio do dominio foram satisfeitas
            // if(resultado do dominio)
            Commit();

            return classeVagaoViewModel;

        }

        public ClasseVagaoViewModel Atualizar(ClasseVagaoViewModel clienteViewModel)
        {
            var classeVagao = Mapper.Map<ClasseVagaoViewModel, ClasseVagao>(clienteViewModel);
            _claseVagaoService.Atualizar(classeVagao);

            Commit();

            return clienteViewModel;
        }

        public void Dispose()
        {
            _claseVagaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ClasseVagaoViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<ClasseVagao, ClasseVagaoViewModel>(_claseVagaoService.ObterPorId(id));
        }

        public IEnumerable<ClasseVagaoViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<ClasseVagao>, IEnumerable<ClasseVagaoViewModel>>(_claseVagaoService.ObterTodos());
        }

        public void Remover(Guid id)
        {
            _claseVagaoService.Remover(id);
            Commit();
        }

        public List<ClasseVagaoViewModel> ObterListaClassesVagoes()
        {
            return Mapper.Map<List<ClasseVagao>, List<ClasseVagaoViewModel>>(_claseVagaoService.ObterListaClassesVagoes());
        }

        
    }
}
