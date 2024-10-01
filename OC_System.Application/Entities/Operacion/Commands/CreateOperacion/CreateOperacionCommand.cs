using OC_System.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Operacion.Commands.CreateOperacion
{
    public record CreateOperacionCommand(Guid id,string oname, string ocode, string odescription, string codigoUnidad) : ICommand<OC_System.Dominio.Entities.Operacion>;
}
