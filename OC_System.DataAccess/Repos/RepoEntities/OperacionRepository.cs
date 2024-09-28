using OC_System_Contracts;
using OC_System_DataAccess.Repos.Common;
using OC_System.Dominio.Entities;
using OC_System.DataAccess.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.DataAccess.Repos.RepoEntities
{
    public class OperacionRepository : RepositoryBase, IOperaracionRepository
    {
        public OperacionRepository(ApplicationContext context) : base(context) { }

        public void AddOperacion(Operacion operacion)
        {
            _context.Operacions.Add(operacion);
        }

        public void DeleteOperacion(Operacion operacion)
        {
            _context.Operacions.Remove(operacion);
        }

        public IEnumerable<Operacion> GetAllOperaciones()
        {
            return _context.Operacions.ToList();
        }

        public  Operacion? GetOperacionByID(Guid id)
        {
            return _context.Operacions.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateOperacion(Operacion operacion) { _context.Operacions.Update(operacion); }



    }
}

