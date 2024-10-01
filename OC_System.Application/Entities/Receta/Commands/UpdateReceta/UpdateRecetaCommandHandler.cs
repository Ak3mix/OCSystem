using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Commands.UpdateFase;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Receta.Commands.UpdateReceta
{
    public class UpdateRecetaCommandHandler :
         ICommandHandler<UpdateRecetaCommand>
    {
        private readonly IRecetaRepository _recetaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateRecetaCommandHandler(IRecetaRepository recetaRepository, IUnitOfWork unitOfWork)
        {
            _recetaRepository = recetaRepository;
            _unitOfWork = unitOfWork;
        }

        public Task Handle(UpdateRecetaCommand request, CancellationToken cancellationToken)
        {
            _recetaRepository.UpdateReceta(request.receta);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }


    }
}
