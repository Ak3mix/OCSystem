using OC_System_Contracts;
using OC_System_DataAccess.Concrete;
using OC_System_DataAccess.Repos.Common;
using OC_System.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System_DataAccess.Repos.RepoEntities
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

