using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OC_System.Contracts.Interfaces
{
    public interface IUnitOfWork 
    {

        void SaveChanges();
    }

}



