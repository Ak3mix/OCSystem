using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Commands.CreateFase;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Commands.DeleteFase
{
    public class DeleteFaseCommandHandler :
        ICommandHandler<DeleteFaseCommand>
    {
        private readonly IFaseRepository _faseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteFaseCommandHandler(IUnitOfWork unitOfWork, IFaseRepository faseRepository)
        {
            _unitOfWork = unitOfWork;
            _faseRepository = faseRepository;
        }
        public Task Handle(DeleteFaseCommand request, CancellationToken cancellationToken)
        {
            var FaseToDelete = _faseRepository.GetFaseByID(request.id);
            if (FaseToDelete == null)
               return Task.CompletedTask;

            _faseRepository.DeleteFase(FaseToDelete);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
