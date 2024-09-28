using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OC_System.GrpcProtos;

namespace GrpcService1.Services
{
    public class FaseService : Fase.FaseBase
    {
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
