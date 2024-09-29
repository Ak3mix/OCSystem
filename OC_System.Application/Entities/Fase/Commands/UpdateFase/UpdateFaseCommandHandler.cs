using OC_System.Application.Abstract;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Commands.UpdateFase
{
    public class UpdateFaseCommandHandler :
          ICommandHandler<UpdateFaseCommand>
    {
        private readonly IFaseRepository _faseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateFaseCommandHandler(IFaseRepository variableRepository, IUnitOfWork unitOfWork)
        {
            _faseRepository = variableRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(UpdateFaseCommand request, CancellationToken cancellationToken)
        {
            _faseRepository.UpdateFase(request.fase);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }


    }
}
