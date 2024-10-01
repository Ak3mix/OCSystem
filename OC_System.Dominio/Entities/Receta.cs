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
        
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string CodigoUnidad { get; set; }

        public List<Fase> Fases { get; set; }
        public List<Operacion> Operaciones { get; set; }

        protected Receta() { }

        public Receta(Guid id,string rnombre, string rcode, string rdescripcion, string codigoUnidad): base(id) 
        {
            Nombre = rnombre;
            Code = rcode;
            Descripcion = rdescripcion;
            CodigoUnidad = codigoUnidad;
            Operaciones = new List<Operacion>();
            Fases =new List<Fase>();
        }
    }
}
