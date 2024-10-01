using MediatR;
using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Query.GetAllFase;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Receta.Query.GetAllReceta
{
    public class GetAllRecetaQueryHandler : IQueryHandler<GetAllRecetaQuery, IEnumerable<OC_System.Dominio.Entities.Receta>>
    {
        private readonly IRecetaRepository _recetaRepository;
        public GetAllRecetaQueryHandler(IRecetaRepository recetaRepository)
        {
            _recetaRepository = recetaRepository;
        }

        Task<IEnumerable<OC_System.Dominio.Entities.Receta>> IRequestHandler<GetAllRecetaQuery, IEnumerable<OC_System.Dominio.Entities.Receta>>.Handle(GetAllRecetaQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_recetaRepository.GetAllReceta());
        }
    }
}
