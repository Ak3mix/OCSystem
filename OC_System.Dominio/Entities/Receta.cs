using OC_System.Dominio.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Dominio.Entities
{
    public class Receta : Entity
    {

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string CodigoUnidad { get; set; }

        public List<Fase> Fase { get; set; }
        public List<Operacion> Operacion { get; set; }

        protected Receta() { }

        public Receta(string rnombre, string rdescripcion, string codigoUnidad)
        {
            Nombre = rnombre;
            Descripcion = rdescripcion;
            CodigoUnidad = codigoUnidad;

        }
    }
}
