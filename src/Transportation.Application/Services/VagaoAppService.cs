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
    public class VagaoAppService : AppService, IVagaoAppService
    {


        private readonly IVagaoService _vagaoService;
        private readonly ISerieVagaoAppService _serieVagaoAppservice;
        private readonly IFerroviaAppService _ferroviaAppservice;


        public VagaoAppService(IVagaoService vagaoService, 
            ISerieVagaoAppService serieVagaoAppservice,
            IFerroviaAppService ferroviaAppservice,
            IUnitOfWork uow) : base(uow)
        {
            _vagaoService = vagaoService;
            _serieVagaoAppservice = serieVagaoAppservice;
            _ferroviaAppservice = ferroviaAppservice;
        }

        public VagaoViewModel Adicionar(VagaoViewModel vagaoViewModel)
        {
            var vagao = Mapper.Map<VagaoViewModel, Vagao>(vagaoViewModel);

            _vagaoService.Adicionar(vagao);
            // add pedido
            // solicitar NF

            // Verificar se todas as regras de negocio do dominio foram satisfeitas
            // if(resultado do dominio)
            Commit();

            return vagaoViewModel;
        }

        public VagaoViewModel Atualizar(VagaoViewModel vagaoViewModel)
        {
            var vagao = Mapper.Map<VagaoViewModel, Vagao>(vagaoViewModel);
            _vagaoService.Atualizar(vagao);

            Commit();
            return vagaoViewModel;
        }

        public void Dispose()
        {
            _vagaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public VagaoViewModel ObterPorId(Guid id)
        {
            VagaoViewModel vagao = Mapper.Map<Vagao, VagaoViewModel>(_vagaoService.ObterPorId(id));
            //Buscar as series 
            vagao.SerieVagao = _serieVagaoAppservice.ObterPorId(vagao.SerieVagaoId) ;
            vagao.FerroviaOperadora = _ferroviaAppservice.ObterPorId(vagao.FerroviaOperadoraId);

            return vagao;
        }

        public IEnumerable<VagaoViewModel> ObterTodos()
        {
            IEnumerable<VagaoViewModel> lista;
            lista = Mapper.Map<IEnumerable<Vagao>, IEnumerable<VagaoViewModel>>(_vagaoService.ObterTodos());

            foreach (VagaoViewModel item in lista)
            {
                item.SerieVagao = _serieVagaoAppservice.ObterPorId(item.SerieVagaoId);
                item.FerroviaOperadora = _ferroviaAppservice.ObterPorId(item.FerroviaOperadoraId);
            }

            return lista;
        }

        public void Remover(Guid id)
        {
            _vagaoService.Remover(id);
        }

      
    }
}
