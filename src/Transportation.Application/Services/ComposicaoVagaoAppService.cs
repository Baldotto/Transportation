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
using Transportation.Domain.Services;
using Transportation.Infra.Data.Interfaces;

namespace Transportation.Application.Services
{
    public class ComposicaoVagaoAppService : AppService, IComposicaoVagaoAppService
    {

        private readonly IComposicaoVagaoService _composicaoVagaoService;

        public ComposicaoVagaoAppService(IComposicaoVagaoService composicaoVagaoService, IUnitOfWork uow) : base(uow)
        {
            _composicaoVagaoService = composicaoVagaoService;
        }

        public ComposicaoVagaoViewModel Adicionar(ComposicaoVagaoViewModel composicaoViewModel)
        {
            var composicao = Mapper.Map<ComposicaoVagaoViewModel, ComposicaoVagao>(composicaoViewModel);

            _composicaoVagaoService.Adicionar(composicao);
            // add pedido
            // solicitar NF

            // Verificar se todas as regras de negocio do dominio foram satisfeitas
            // if(resultado do dominio)
            Commit();

            return composicaoViewModel;
        }

        public ComposicaoVagaoViewModel Atualizar(ComposicaoVagaoViewModel composicaoViewModel)
        {
            var composicao = Mapper.Map<ComposicaoVagaoViewModel, ComposicaoVagao>(composicaoViewModel);
            _composicaoVagaoService.Atualizar(composicao);

            Commit();
            return composicaoViewModel;
        }

        public void Dispose()
        {
            _composicaoVagaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ComposicaoVagaoViewModel ObterPorComposicaoId(Guid id)
        {
            ComposicaoVagaoViewModel composicao = Mapper.Map<ComposicaoVagao, ComposicaoVagaoViewModel>(_composicaoVagaoService.ObterPorComposicaoId(id));
      
            return composicao;
        }

        public ComposicaoVagaoViewModel ObterPorId(Guid id)
        {
            ComposicaoVagaoViewModel composicao = Mapper.Map<ComposicaoVagao, ComposicaoVagaoViewModel>(_composicaoVagaoService.ObterPorId(id));

            return composicao;
        }

        public IEnumerable<ComposicaoVagaoViewModel> ObterTodos()
        {
            IEnumerable<ComposicaoVagaoViewModel> lista;
            lista = Mapper.Map<IEnumerable<ComposicaoVagao>, IEnumerable<ComposicaoVagaoViewModel>>(_composicaoVagaoService.ObterTodos());
            return lista;
        }

        public void Remover(Guid id)
        {
            _composicaoVagaoService.Remover(id);
        }
    }
}
