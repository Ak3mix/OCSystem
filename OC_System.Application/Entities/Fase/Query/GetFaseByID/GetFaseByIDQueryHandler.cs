using OC_System.Application.Abstract;
using OC_System.Contracts;
using OC_System.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OC_System.Application.Entities.Fase.Query.GetFaseByID
{
    public class GetFaseByIDQueryHandler : IQueryHandler<GetFaseByIDQuery, OC_System.Dominio.Entities.Fase?>

    {
       private readonly IFaseRepository _faseRepository;

        public GetFaseByIDQueryHandler(IFaseRepository faseRepository)
        {
            _faseRepository = faseRepository;
        }

        

        public Task<OC_System.Dominio.Entities.Fase?> Handle(GetFaseByIDQuery request , CancellationToken cancellationToken) 
        { return Task.FromResult(_faseRepository.GetFaseByID(request.Id)); }
    }
}
