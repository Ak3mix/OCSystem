using OC_System.Dominio.Entities;
using System.Data.SqlTypes;

namespace OC_System.Contracts


{
    public interface IOperaracionRepository
    {

        void AddOperacion(Operacion operacion);

        Operacion? GetOperacionByID(Guid id);

        public IEnumerable<Operacion> GetAllOperaciones();

        void UpdateOperacion(Operacion operacion);

        void DeleteOperacion(Operacion operacion);

    }
}