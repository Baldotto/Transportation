using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.Application.ViewModels;
using Transportation.Domain.Entities;

namespace Transportation.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Ferrovia, FerroviaViewModel>();
            Mapper.CreateMap<ClasseVagao, ClasseVagaoViewModel>();
            Mapper.CreateMap<SerieVagao, SerieVagaoViewModel>();
            Mapper.CreateMap<Vagao, VagaoViewModel>();
            Mapper.CreateMap<Trem, TremViewModel>();
            Mapper.CreateMap<Composicao, ComposicaoViewModel>();
            Mapper.CreateMap<ComposicaoVagao, ComposicaoVagaoViewModel>();

        }
    }
}
