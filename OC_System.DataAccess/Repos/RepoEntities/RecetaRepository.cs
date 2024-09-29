using OC_System_Contracts;
using OC_System.DataAccess.Concrete;
using OC_System.DataAccess.Repos.Common;
using OC_System.Dominio.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OC_System.Contracts;

namespace OC_System.DataAccess.Repos.RepoEntities
{
    public class RecetaRepository : RepositoryBase, IRecetaRepository
    {
        public RecetaRepository(ApplicationContext context) : base(context) { }

        public void AddReceta(Receta receta)
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

