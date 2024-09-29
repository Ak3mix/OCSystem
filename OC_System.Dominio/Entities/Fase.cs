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
        public string Code;
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Receta? Receta { get; set; }

        public Guid RecetaId { get; set; }
        public List<Operacion> Operacion { get; set; } = new List<Operacion>();




        protected Fase() { }

        public Fase(string nombre, string code, string descripcion, Receta? receta)
        {
            Nombre = nombre;
            Code = code;
            Descripcion = descripcion;
            Receta= receta;
            RecetaId= receta.Id;

           

        }
    }
}
