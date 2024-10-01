using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OC_System.GrpcProtos;
using OC_System_Contracts;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using AutoMapper;
using AutoMapper;
using MediatR;

namespace GrpcService1.Services
{
    public class FaseService : Fase.FaseBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public FaseService(IMediator mediator,IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        

        public override Task<FaseDTO> CreateFase(CreateFaseRequest request, ServerCallContext context)
        {
            return base.CreateFase(request, context);
        }

        public override Task<Empty> DeleteFase(DeleteRequest request, ServerCallContext context)
        {
            return base.DeleteFase(request, context);
        }

      
        public override Task<Fases> GetAllFase(Empty request, ServerCallContext context)
        {
            return base.GetAllFase(request, context);
        }
        public override Task<NullableFaseDTO> GetFase(GetRequest request, ServerCallContext context)
        {
            return base.GetFase(request, context);
        }

        public override Task<Empty> UpdateFase(FaseDTO request, ServerCallContext context)
        {
            return base.UpdateFase(request, context);
        }
    }
}
