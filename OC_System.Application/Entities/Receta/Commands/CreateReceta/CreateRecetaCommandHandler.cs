using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Commands.CreateFase;
using OC_System.Contracts.Interfaces;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Receta.Commands.CreateReceta
{
    public class CreateRecetaCommandHandler :
        ICommandHandler<CreateRecetaCommand, OC_System.Dominio.Entities.Receta>
    {
        private readonly IRecetaRepository _recetaRepository;
        private readonly IUnitOfWork _unitOfWork;

        public Task<OC_System.Dominio.Entities.Receta> Handle(CreateRecetaCommand request, CancellationToken cancellationToken)
        {
            OC_System.Dominio.Entities.Receta result = new Dominio.Entities.Receta(request.id, request.rname, request.rcode, request.rdescription, request.codeUnidad);

            _recetaRepository.AddReceta(result);
            _unitOfWork.SaveChanges();
            return Task.FromResult(result);
        }

    }
}
