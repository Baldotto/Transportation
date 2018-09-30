using AutoMapper;
using System;
using System.Collections.Generic;
using Transportation.Application.Interfaces;
using Transportation.Application.ViewModels;
using Transportation.Domain.Entities;
using Transportation.Domain.Interfaces.Services;
using Transportation.Infra.Data.Interfaces;

namespace Transportation.Application.Services
{
    public class SerieVagaoAppService : AppService, ISerieVagaoAppService
    {

        private readonly ISerieVagaoService _serieVagaoService;
        private readonly IClasseVagaoAppService _classeVagaoAppService;
        public SerieVagaoAppService(ISerieVagaoService serieVagaoService, 
                                    IClasseVagaoAppService classeVagaoAppService,
                                    IUnitOfWork uow) : base(uow)    
        {
            _serieVagaoService = serieVagaoService;
            _classeVagaoAppService = classeVagaoAppService;
        }

        public SerieVagaoViewModel Adicionar(SerieVagaoViewModel serieVagaoViewModel)
        {
            var serie_vagao = Mapper.Map<SerieVagaoViewModel, SerieVagao>(serieVagaoViewModel);

            _serieVagaoService.Adicionar(serie_vagao);
            // add pedido
            // solicitar NF

            // Verificar se todas as regras de negocio do dominio foram satisfeitas
            // if(resultado do dominio)
            Commit();

            return serieVagaoViewModel;
        }

        public SerieVagaoViewModel Atualizar(SerieVagaoViewModel serieVagaoViewModel)
        {
            var serie_vagao = Mapper.Map<SerieVagaoViewModel, SerieVagao>(serieVagaoViewModel);
            _serieVagaoService.Atualizar(serie_vagao);

            Commit();
            return serieVagaoViewModel;
        }

        public void Dispose()
        {
            _serieVagaoService.Dispose();
            GC.SuppressFinalize(this);
        }

        public SerieVagaoViewModel ObterPorId(Guid id)
        {
            SerieVagaoViewModel serie = Mapper.Map<SerieVagao, SerieVagaoViewModel>(_serieVagaoService.ObterPorId(id));

            serie.ClasseVagao = _classeVagaoAppService.ObterPorId(serie.ClasseVagaoId);

            return serie;
        }

        public IEnumerable<SerieVagaoViewModel> ObterTodos()
        {

            IEnumerable<SerieVagaoViewModel> lista;
            lista = Mapper.Map<IEnumerable<SerieVagao>, IEnumerable<SerieVagaoViewModel>>(_serieVagaoService.ObterTodos());

            foreach (SerieVagaoViewModel item in lista)
            {           
                item.ClasseVagao  = _classeVagaoAppService.ObterPorId(item.ClasseVagaoId);
            }

            return lista;
        }

        public void Remover(Guid id)
        {
            _serieVagaoService.Remover(id);
        }

        public List<ClasseVagaoViewModel> ListaClassesVagoes()
        {

            //Não precisa de implmentar aqui, chamar o APP direto na controller.????
            return _classeVagaoAppService.ObterListaClassesVagoes();
            
            // return _serieVagaoService.ListaClassesVagoes();
        }

        public List<SerieVagaoViewModel> ListaSerieVagoes()
        {
            return Mapper.Map<List<SerieVagao>, List<SerieVagaoViewModel>>(_serieVagaoService.ListaSerieVagoes());
        }
    }
}
