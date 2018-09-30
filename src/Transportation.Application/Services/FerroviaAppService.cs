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
    public class FerroviaAppService : AppService, IFerroviaAppService
    {

        private readonly IFerroviaService _ferroviaService;

        public FerroviaAppService(IFerroviaService ferroviaService, IUnitOfWork uow)
            : base(uow)
        {
            _ferroviaService = ferroviaService;
        }



        public FerroviaViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Ferrovia, FerroviaViewModel>(_ferroviaService.ObterPorId(id));
        }

        public FerroviaViewModel Adicionar(FerroviaViewModel ferroviaViewModel)
        {
            var ferrovia = Mapper.Map<FerroviaViewModel, Ferrovia>(ferroviaViewModel);

            _ferroviaService.Adicionar(ferrovia);
            // add pedido
            // solicitar NF

            // Verificar se todas as regras de negocio do dominio foram satisfeitas
            // if(resultado do dominio)
            Commit();

            return ferroviaViewModel;
        }


        public IEnumerable<FerroviaViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Ferrovia>, IEnumerable<FerroviaViewModel>>(_ferroviaService.ObterTodos());
        }

        public FerroviaViewModel Atualizar(FerroviaViewModel ferroviaViewModel)
        {
            var ferrovia = Mapper.Map<FerroviaViewModel, Ferrovia>(ferroviaViewModel);
            _ferroviaService.Atualizar(ferrovia);

            return ferroviaViewModel;
        }

        public void Remover(Guid id)
        {
            _ferroviaService.Remover(id);
        }

        public void Dispose()
        {
            _ferroviaService.Dispose();
            GC.SuppressFinalize(this);
        }

        public List<FerroviaViewModel> ListaFerrovias()
        {
            return Mapper.Map<List<Ferrovia>, List<FerroviaViewModel>>(_ferroviaService.ListaFerrovias());
        }
    }
}
