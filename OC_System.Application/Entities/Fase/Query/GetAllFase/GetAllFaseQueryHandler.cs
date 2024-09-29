using MediatR;
using OC_System.Application.Abstract;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Query.GetAllFase
{
    public class  GetAllFaseQueryHandler : IQueryHandler<GetAllFaseQuery, IEnumerable<OC_System.Dominio.Entities.Fase>>
    {
        private readonly IFaseRepository _faseRepository;
        public GetAllFaseQueryHandler( IFaseRepository faseRepository)
        {
           _faseRepository = faseRepository;
        }

        Task<IEnumerable<OC_System.Dominio.Entities.Fase>> IRequestHandler<GetAllFaseQuery, IEnumerable<OC_System.Dominio.Entities.Fase>>.Handle(GetAllFaseQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_faseRepository.GetAllFases());
        }
    }
}
