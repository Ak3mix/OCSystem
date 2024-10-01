using OC_System.Application.Abstract;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Receta.Commands.DeleteReceta
{
    public class DeleteRecetaCommandHandler :
        ICommandHandler<DeleteRecetaCommand>
    {
        private readonly IRecetaRepository _recetaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRecetaCommandHandler(IUnitOfWork unitOfWork, IRecetaRepository recetaRepository)
        {
            _unitOfWork = unitOfWork;
            _recetaRepository = recetaRepository;
        }
        public Task Handle(DeleteRecetaCommand request, CancellationToken cancellationToken)
        {
            var RecetaToDelete = _recetaRepository.GetFaseByID(request.id);
            if (RecetaToDelete == null)
                return Task.CompletedTask;

            _recetaRepository.DeleteReceta(RecetaToDelete);
            _unitOfWork.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
