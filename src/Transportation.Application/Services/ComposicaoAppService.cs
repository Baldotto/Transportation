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
    public class ComposicaoAppService : AppService, IComposicaoAppService
    {

        private readonly IComposicaoService _composicaoService;

        public ComposicaoAppService(IComposicaoService composicaoService, IUnitOfWork uow) : base(uow)
        {
            _composicaoService = composicaoService;

        }

        public ComposicaoViewModel Adicionar(ComposicaoViewModel composicaoViewModel)
        {
            var composicao = Mapper.Map<ComposicaoViewModel, Composicao>(composicaoViewModel);

            _composicaoService.Adicionar(composicao);
            // add pedido
            // solicitar NF

            // Verificar se todas as regras de negocio do dominio foram satisfeitas
            // if(resultado do dominio)
            Commit();

            return composicaoViewModel;
        }

        public ComposicaoViewModel Atualizar(ComposicaoViewModel composicaoViewModel)
        {
            var composicao = Mapper.Map<ComposicaoViewModel, Composicao>(composicaoViewModel);
            _composicaoService.Atualizar(composicao);

            Commit();
            return composicaoViewModel;
        }

        public void Dispose()
        {
            _composicaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public ComposicaoViewModel ObterPorId(Guid id)
        {
            ComposicaoViewModel composicao = Mapper.Map<Composicao, ComposicaoViewModel>(_composicaoService.ObterPorId(id));


            return composicao;
        }

        public ComposicaoViewModel ObterPorTremId(Guid id)
        {
            ComposicaoViewModel composicao = Mapper.Map<Composicao, ComposicaoViewModel>(_composicaoService.ObterPorTremId(id));

            return composicao;
        }

        public IEnumerable<ComposicaoViewModel> ObterTodos()
        {
            IEnumerable<ComposicaoViewModel> lista;
            lista = Mapper.Map<IEnumerable<Composicao>, IEnumerable<ComposicaoViewModel>>(_composicaoService.ObterTodos());
            return lista;
        }

        public void Remover(Guid id)
        {
            _composicaoService.Remover(id);
        }
    }
}
