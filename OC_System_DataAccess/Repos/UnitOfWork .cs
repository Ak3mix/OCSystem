using Microsoft.EntityFrameworkCore;
using OC_System_Contracts.Interfaces;
using OC_System_DataAccess.Concrete;

namespace OC_System_Contracts
{
    
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext contex)
        {
            _context = contex;
            if (!contex.Database.CanConnect())
                contex.Database.Migrate();
        }
        public void SaveChanges() { 
        
         _context.SaveChanges();
        }
       
    }
}
