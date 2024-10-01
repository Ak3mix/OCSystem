using MediatR;
using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Query.GetAllFase;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Operacion.Query.GetAllOperacion
{
    public class GetAllOperacionQueryHandler : IQueryHandler<GetAllOperacionQuery, IEnumerable<OC_System.Dominio.Entities.Operacion>>
    {
        private readonly IOperaracionRepository _operacionRepository;
        public GetAllOperacionQueryHandler(IOperaracionRepository operacionRepository)
        {
            _operacionRepository = operacionRepository;
        }

        Task<IEnumerable<OC_System.Dominio.Entities.Operacion>> IRequestHandler<GetAllOperacionQuery, IEnumerable<OC_System.Dominio.Entities.Operacion>>.Handle(GetAllOperacionQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_operacionRepository.GetAllOperaciones());
        }
    }
}
