using AutoMapper;
using Transportation.Application.ViewModels;
using Transportation.Domain.Entities;

namespace Transportation.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {

        protected override void Configure()
        {
            Mapper.CreateMap<FerroviaViewModel, Ferrovia>();
            Mapper.CreateMap<ClasseVagaoViewModel, ClasseVagao>();
            Mapper.CreateMap<SerieVagaoViewModel, SerieVagao>();
            Mapper.CreateMap<VagaoViewModel, Vagao>();
            Mapper.CreateMap<TremViewModel, Trem>();
            Mapper.CreateMap<ComposicaoViewModel, Composicao>();
            Mapper.CreateMap<ComposicaoVagaoViewModel, ComposicaoVagao>();
        }
    }
}
