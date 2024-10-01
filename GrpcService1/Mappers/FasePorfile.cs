using AutoMapper;
using System.Globalization;

namespace GrpcService1.Mappers
{
    public class FaseProfile : Profile
    {
        public FaseProfile()
        {
            CreateMap<OC_System.Dominio.Entities.Fase,
                OC_System.GrpcProtos.FaseDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(t => t.Name, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Descripcion))
                .ForMember(t => t.Code, o => o.MapFrom(s => s.Code));



            CreateMap<OC_System.GrpcProtos.FaseDTO,
                OC_System.Dominio.Entities.Fase>()
                .ForMember(t => t.Id, o => o.MapFrom(s => new Guid(s.Id)))
                .ForMember(t => t.Code, o => o.MapFrom(s => s.Code))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Name))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Descripcion));
        }
    }
}
