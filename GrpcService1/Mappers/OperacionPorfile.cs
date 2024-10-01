using AutoMapper;

namespace GrpcService1.Mappers
{
    public class OperacionProfile : Profile
    {
        public OperacionProfile()
        {
            CreateMap<OC_System.Dominio.Entities.Operacion,
                OC_System.GrpcProtos.OperacionDTO>()
                .ForMember(t => t.Id, o => o.MapFrom(s => s.Id.ToString()))
                .ForMember(t => t.Onombre, o => o.MapFrom(s => s.Nombre))
                .ForMember(t => t.Odescripcion, o => o.MapFrom(s => s.Descripcion))
                .ForMember(t => t.Ocode, o => o.MapFrom(s => s.Code))
                .ForMember(t => t.OcodigoUnidad, o => o.MapFrom(s => s.CodigoUnidad));


            CreateMap<OC_System.GrpcProtos.OperacionDTO,
                OC_System.Dominio.Entities.Operacion>()
                .ForMember(t => t.Id, o => o.MapFrom(s => new Guid(s.Id)))
                .ForMember(t => t.Code, o => o.MapFrom(s => s.Ocode))
                .ForMember(t => t.Nombre, o => o.MapFrom(s => s.Onombre))
                .ForMember(t => t.Descripcion, o => o.MapFrom(s => s.Odescripcion))
                .ForMember(t => t.CodigoUnidad, o => o.MapFrom(s => s.OcodigoUnidad));
        }
    }
}

