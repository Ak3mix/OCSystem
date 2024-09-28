using OC_System.Dominio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Dominio.Entities
{
    public class Fase : Entity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Receta? Receta { get; set; }

        public Guid RecetaId { get; set; }
        public List<Operacion> Operacion { get; set; }




        protected Fase() { }

        public Fase(string nombre, string descripcion, Receta? receta)
        {
            Nombre = nombre;

            Descripcion = descripcion;
            Receta= receta;
            RecetaId= receta.Id;

        }
    }
}
