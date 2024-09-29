using OC_System.Application.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Commands.UpdateFase
{
    public record UpdateFaseCommand(OC_System.Dominio.Entities.Fase fase) : ICommand;
}
