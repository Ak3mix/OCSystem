using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Commands.CreateFase;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OC_System.Application.Entities.Operacion.Commands.CreateOperacion
{
    public class CreateOperacionCommandHandler :
         ICommandHandler<CreateOperacionCommand, OC_System.Dominio.Entities.Operacion>
    {
        private readonly IOperaracionRepository _operacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public Task<OC_System.Dominio.Entities.Operacion> Handle(CreateOperacionCommand request, CancellationToken cancellationToken)
        {
            OC_System.Dominio.Entities.Operacion result = new Dominio.Entities.Operacion(request.id, request.oname, request.ocode, request.odescription, request.codigoUnidad);

            _operacionRepository.AddOperacion(result);
            _unitOfWork.SaveChanges();
            return Task.FromResult(result);
        }

    }

}
