using OC_System.Dominio.Entities;
using System.Data.SqlTypes;

namespace OC_System.Contracts


{
    public interface IFaseRepository
    {

        void AddFase(Fase fase);

        Fase? GetFaseByID(Guid id);

        public IEnumerable<Fase> GetAllFases(); 

        void UpdateFase(Fase fase);
        
        void DeleteFase(Fase fase);

    }

}
