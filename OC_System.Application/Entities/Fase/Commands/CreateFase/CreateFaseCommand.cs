using OC_System.Application.Abstract;
using OC_System.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Application.Entities.Fase.Commands.CreateFase
{
    public record CreateFaseCommand(Guid id, string nombre,string code, string descripcion) : ICommand<OC_System.Dominio.Entities.Fase>;
}
