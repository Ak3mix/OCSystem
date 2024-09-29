using OC_System.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Operacion.Commands.DeleteOperacion
{
    public record DeleteOperacionCommand(Guid id) : ICommand;
}
