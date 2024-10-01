using OC_System.Application.Abstract;
using OC_System.Contracts;
using OC_System.Contracts.Interfaces;
using OC_System.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Commands.CreateFase
{

    public class CreateFaseCommandHandler :
        ICommandHandler<CreateFaseCommand, OC_System.Dominio.Entities.Fase>
    {
        private readonly IFaseRepository _faseRepository;
        private readonly IUnitOfWork _unitOfWork;

        public Task<OC_System.Dominio.Entities.Fase> Handle(CreateFaseCommand request, CancellationToken cancellationToken)
        {
            OC_System.Dominio.Entities.Fase result = new Dominio.Entities.Fase(request.id, request.nombre, request.code, request.descripcion);

            _faseRepository.AddFase(result);
            _unitOfWork.SaveChanges();
            return Task.FromResult(result);
        }

    } 
}