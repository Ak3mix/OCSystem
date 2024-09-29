using OC_System.Application.Abstract;
using OC_System.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Commands.CreateFase
{
    public record CreateFaseCommand(string name, string code,string description, OC_System.Dominio.Entities.Receta Receta) : ICommand<OC_System.Dominio.Entities.Fase>;
}
