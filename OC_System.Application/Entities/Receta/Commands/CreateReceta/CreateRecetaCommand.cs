using OC_System.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Receta.Commands.CreateReceta
{
    public record CreateRecetaCommand(Guid id,string rname,string rcode, string rdescription, string codeUnidad) : ICommand<OC_System.Dominio.Entities.Receta>;
}
