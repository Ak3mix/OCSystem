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
    public class FaseRepository : RepositoryBase, IFaseRepository
    {
        public FaseRepository(ApplicationContext context) : base(context) { }

        public void AddFase(Fase fase)
        {
            _context.Fases.Add(fase);
        }

        public void DeleteFase(Fase fase)
        {
            _context.Fases.Remove(fase);
        }

        public IEnumerable<Fase> GetAllFases()
        {
            return _context.Fases.ToList();
        }

        public Fase? GetFaseByID(Guid id)
        {
            return _context.Fases.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateFase(Fase fase) { _context.Fases.Update(fase); }



    } }

