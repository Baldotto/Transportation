using Transportation.Application.Interfaces;
using Transportation.Application.Services;
using Transportation.Domain.Interfaces.Services;
using Transportation.Domain.Repository;
using Transportation.Domain.Services;
using Transportation.Infra.Data.Context;
using Transportation.Infra.Data.Repository;
using SimpleInjector;
using Transportation.Infra.Data.Interfaces;
using Transportation.Infra.Data.UnitOfWork;
using Transportation.Domain.Interfaces.Repository;

namespace Transportation.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // APP            
            container.Register<IFerroviaAppService, FerroviaAppService>(Lifestyle.Scoped);
            container.Register<IClasseVagaoAppService, ClasseVagaoAppService>(Lifestyle.Scoped);
            container.Register<ISerieVagaoAppService, SerieVagaoAppService>(Lifestyle.Scoped);
            container.Register<IVagaoAppService, VagaoAppService>(Lifestyle.Scoped);
            container.Register<ITremAppService, TremAppService>(Lifestyle.Scoped);
            container.Register<IComposicaoAppService, ComposicaoAppService>(Lifestyle.Scoped);
            container.Register<IComposicaoVagaoAppService, ComposicaoVagaoAppService>(Lifestyle.Scoped);


            // Domain
            container.Register<IFerroviaService, FerroviaService>(Lifestyle.Scoped);
            container.Register<IClasseVagaoService, ClasseVagaoService>(Lifestyle.Scoped);
            container.Register<ISerieVagaoService, SerieVagaoService>(Lifestyle.Scoped);
            container.Register<IVagaoService, VagaoService>(Lifestyle.Scoped);
            container.Register<ITremService, TremService>(Lifestyle.Scoped);
            container.Register<IComposicaoService, ComposicaoService>(Lifestyle.Scoped);
            container.Register<IComposicaoVagaoService, ComposicaoVagaoService>(Lifestyle.Scoped);


            // Dados
            container.Register<IFerroviaRepository, FerroviaRepository>(Lifestyle.Scoped);
            container.Register<IClasseVagaoRepository, ClasseVagaoRepository>(Lifestyle.Scoped);
            container.Register<ISerieVagaoRepository, SerieVagaoRepository>(Lifestyle.Scoped);
            container.Register<IVagaoRepository, VagaoRepository>(Lifestyle.Scoped);
            container.Register<ITremRepository, TremRepository>(Lifestyle.Scoped);
            container.Register<IComposicaoRepository, ComposicaoRepository>(Lifestyle.Scoped);
            container.Register<IComposicaoVagaoRepository, ComposicaoVagaoRepository>(Lifestyle.Scoped);

            //container.Register(typeof(IRepository<>), typeof(Repository<>));
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<TransportationContext>(Lifestyle.Scoped);
        }
    }
}
