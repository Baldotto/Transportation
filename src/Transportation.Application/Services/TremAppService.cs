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
    public class TremAppService : AppService, ITremAppService
    {

        private readonly ITremService _tremService;
        private readonly IComposicaoAppService _composicaoAppService;

        public TremAppService(ITremService tremService, IComposicaoAppService composicaoAppService, IUnitOfWork uow) : base(uow)
        {

            _tremService = tremService;
            _composicaoAppService = composicaoAppService;

        }

        public TremViewModel Adicionar(TremViewModel tremViewModel)
        {
            var trem = Mapper.Map<TremViewModel, Trem>(tremViewModel);

            ComposicaoViewModel composicaoViewModel = new ComposicaoViewModel();

            composicaoViewModel.TremId = trem.TremId;
            composicaoViewModel.IndicadorAtivo = true;

            _tremService.Adicionar(trem);
            _composicaoAppService.Adicionar(composicaoViewModel);
            
            Commit();

            return tremViewModel;
        }

        public TremViewModel Atualizar(TremViewModel tremViewModel)
        {
            var trem = Mapper.Map<TremViewModel, Trem>(tremViewModel);
            _tremService.Atualizar(trem);

            Commit();
            return tremViewModel;
        }

        public void Dispose()
        {
            _tremService.Dispose();
            GC.SuppressFinalize(this);
        }

        public TremViewModel ObterPorId(Guid id)
        {
            TremViewModel vagao = Mapper.Map<Trem, TremViewModel>(_tremService.ObterPorId(id));
            

            return vagao;
        }

        public IEnumerable<TremViewModel> ObterTodos()
        {
            IEnumerable<TremViewModel> lista;
            lista = Mapper.Map<IEnumerable<Trem>, IEnumerable<TremViewModel>>(_tremService.ObterTodos());        
            return lista;
        }

        public void Remover(Guid id)
        {
            
            _tremService.Remover(id);
            Commit();
        }
    }
}
