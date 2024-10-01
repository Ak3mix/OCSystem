using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OC_System.GrpcProtos;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using AutoMapper;
using MediatR;

namespace GrpcService1.Services
{
    public class OperacionService : Operacion.OperacionBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OperacionService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        public override Task<OperacionDTO> CreateOperacion(CreateOperacionRequest request, ServerCallContext context)
        {
            return base.CreateOperacion(request, context);
        }
        public override Task<Operaciones> GetAllOperacion(Empty request, ServerCallContext context)
        {
            return base.GetAllOperacion(request, context);
        }
        public override Task<NullableOperacionDTO> GetOperacion(GetRequest request, ServerCallContext context)
        {
            return base.GetOperacion(request, context);
        }
        public override Task<Empty> UpdateOperacion(OperacionDTO request, ServerCallContext context)
        {
            return base.UpdateOperacion(request, context);
        }
        public override Task<Empty> DeleteOperacion(DeleteRequest request, ServerCallContext context)
        {
            return base.DeleteOperacion(request, context);
        }
    }
}
