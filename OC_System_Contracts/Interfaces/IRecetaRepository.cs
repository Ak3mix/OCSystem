using OC_System.Domain.Entities;
using System.Data.SqlTypes;

namespace OC_System_Contracts


{
    public interface IRecetaRepository
    {

        void AddOperacion(Receta receta);

        Receta? GetRecetaByID(Guid id);

        public IEnumerable<Receta> GetAllReceta();

        void UpdateReceta(Receta receta);

        void DeleteReceta(Receta receta);

    }
}