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
        public List<Receta> Recetas { get; set; }
        public List<Operacion> Operaciones { get; set; }




        protected Fase() { }

        public Fase(Guid id, string nombre, string code, string descripcion) : base(id)
        {
            Nombre = nombre;
            Code = code;
            Descripcion = descripcion;

            Operaciones= new List<Operacion>();
            Recetas= new List<Receta>();


        }
    }
}
