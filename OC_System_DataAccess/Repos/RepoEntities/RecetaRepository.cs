using OC_System_Contracts;
using OC_System_DataAccess.Concrete;
using OC_System_DataAccess.Repos.Common;
using OC_System.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System_DataAccess.Repos.RepoEntities
{
    public class RecetaRepository : RepositoryBase, IRecetaRepository
    {
        public RecetaRepository(ApplicationContext context) : base(context) { }

        public void AddOperacion(Receta receta)
        {
            _context.Recetas.Add(receta);
        }

        public void DeleteReceta(Receta receta)
        {
            _context.Recetas.Remove(receta);
        }

        public IEnumerable<Receta> GetAllReceta()
        {
            return _context.Recetas.ToList();
        }

        public Receta? GetRecetaByID(Guid id)
        {
            return _context.Recetas.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateReceta(Receta receta) { _context.Recetas.Update(receta); }



    }
}

