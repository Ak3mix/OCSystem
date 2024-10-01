using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Commands.UpdateFase;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Operacion.Commands.UpdateOperacion
{
    public class UpdateOperacionCommandHandler :
         ICommandHandler<UpdateOperacionCommand>
    {
        private readonly IOperaracionRepository _operacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateOperacionCommandHandler(IOperaracionRepository operacionRepository, IUnitOfWork unitOfWork)
        {
            _operacionRepository = operacionRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(UpdateOperacionCommand request, CancellationToken cancellationToken)
        {
            _operacionRepository.UpdateOperacion(request.operacion);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }
    }
}