using OC_System.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Query.GetFaseByID
{
    public record GetFaseByIDQuery(Guid Id) : IQuery<OC_System.Dominio.Entities.Fase?>;
}
