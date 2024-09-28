using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OC_System.GrpcProtos;

namespace GrpcService1.Services
{
    public class OperacionService : Operacion.OperacionBase
    {
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
