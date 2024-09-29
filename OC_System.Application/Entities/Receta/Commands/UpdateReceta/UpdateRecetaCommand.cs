using OC_System.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Receta.Commands.UpdateReceta
{
    public record UpdateRecetaCommand(OC_System.Dominio.Entities.Receta receta) : ICommand;
}
