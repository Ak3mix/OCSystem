using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Query.GetFaseByID;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Operacion.Query.GetOperacionByID
{
    public class GetOperacionByIDQueryHandler : IQueryHandler<GetOperacionByIDQuery, OC_System.Dominio.Entities.Operacion?>

    {
        private readonly IOperaracionRepository _operacionRepository;

        public GetOperacionByIDQueryHandler(IOperaracionRepository operacionRepository)
        {
            _operacionRepository = operacionRepository;
        }



        public Task<OC_System.Dominio.Entities.Operacion?> Handle(GetOperacionByIDQuery request, CancellationToken cancellationToken)
        { return Task.FromResult(_operacionRepository.GetOperacionByID(request.Id)); }
    }
}
