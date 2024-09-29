using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using OC_System.GrpcProtos;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;

namespace GrpcService1.Services
{
    public class RecetaService : Receta.RecetaBase
    {

        private IRecetaRepository _recetaRepository;
        private IUnitOfWork _unitOfWork;

        public RecetaService(IRecetaRepository recetaRepository, IUnitOfWork unitOfWork)
        {
            _recetaRepository = recetaRepository;
            _unitOfWork = unitOfWork;
        }
        public override Task<RecetaDTO> CreateReceta(CreateRecetaRequest request, ServerCallContext context)
        {
            return base.CreateReceta(request, context);
        }
        public override Task<Recetas> GetAllRecetas(Empty request, ServerCallContext context)
        {
            return base.GetAllRecetas(request, context);

        }
        public override Task<NullableRecetaDTO> GetReceta(GetRequest request, ServerCallContext context)
        {
            return base.GetReceta(request, context);
        }
        public override Task<Empty> UpdateReceta(RecetaDTO request, ServerCallContext context)
        {
            return base.UpdateReceta(request, context);
        }
        public override Task<Empty> DeleteReceta(DeleteRequest request, ServerCallContext context)
        {
            return base.DeleteReceta(request, context);
        }
    }
}
