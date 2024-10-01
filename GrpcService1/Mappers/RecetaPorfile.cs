using AutoMapper;

namespace GrpcService1.Mappers
{
    public class RecetaProfile : Profile
    {
        public RecetaProfile()
        {
            CreateMap<OC_System.Dominio.Entities.Receta,
                OC_System.GrpcProtos.RecetaDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(t => t.Rnombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Rdescripcion, o => o.MapFrom(s => s.Descripcion))
                .ForMember(t => t.Rcode, o => o.MapFrom(s => s.Code))
                .ForMember(t => t.UnidadCodigo, o => o.MapFrom(s => s.CodigoUnidad));


            CreateMap<OC_System.GrpcProtos.RecetaDTO,
                OC_System.Dominio.Entities.Receta>()
                .ForMember(t => t.Id, o => o.MapFrom(s => new Guid(s.Id)))
                .ForMember(t => t.Code, o => o.MapFrom(s => s.Rcode))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Rnombre))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Rdescripcion))
                .ForMember(t => t.CodigoUnidad, o => o.MapFrom(s => s.UnidadCodigo));
        }
    }
}