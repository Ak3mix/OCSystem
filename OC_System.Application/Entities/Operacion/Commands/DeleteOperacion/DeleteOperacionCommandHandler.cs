using OC_System.Application.Abstract;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OC_System.Application.Entities.Operacion.Commands.DeleteOperacion;
using OC_System.DataAccess.Repos.RepoEntities;

namespace OC_System.Application.Entities.Operacion.Commands.DeleteOperacion
{
    public class DeleteOperacionCommandHandler :
        ICommandHandler<DeleteOperacionCommand>
    {
        private readonly IOperaracionRepository _operacionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteOperacionCommandHandler(IUnitOfWork unitOfWork, IOperaracionRepository operacionRepository)
        {
            _unitOfWork = unitOfWork;
            _operacionRepository = operacionRepository;
        }
        public Task Handle(DeleteOperacionCommand request, CancellationToken cancellationToken)
        {
            var OperacionToDelete = _operacionRepository.GetOperacionByID(request.id);
            if (OperacionToDelete == null)
               return Task.CompletedTask;

            _operacionRepository.DeleteOperacion(OperacionToDelete);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
