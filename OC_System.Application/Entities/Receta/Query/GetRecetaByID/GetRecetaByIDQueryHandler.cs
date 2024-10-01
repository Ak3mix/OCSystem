using OC_System.Application.Abstract;
using OC_System.Application.Entities.Fase.Query.GetFaseByID;
using OC_System.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Receta.Query.GetAllReceta
{
    public class GetRecetaByIDQueryHandler : IQueryHandler<GetRecetaByIDQuery, OC_System.Dominio.Entities.Receta?>

    {
        private readonly IRecetaRepository _recetaRepository;

        public GetRecetaByIDQueryHandler(IRecetaRepository recetaRepository)
        {
            _recetaRepository = recetaRepository;
        }



        public Task<OC_System.Dominio.Entities.Receta?> Handle(GetRecetaByIDQuery request, CancellationToken cancellationToken)
        { return Task.FromResult(_recetaRepository.GetRecetaByID(request.Id)); }
    }
}
