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
        
        public string rCode { get; set; }
        public string Descripcion { get; set; }
        public string CodigoUnidad { get; set; }

        public List<Fase> Fase { get; set; }=new List<Fase>();
        public List<Operacion> Operacion { get; set; }= new List<Operacion>();

        protected Receta() { }

        public Receta(string rnombre, string rcode, string rdescripcion, string codigoUnidad)
        {
            Nombre = rnombre;
            rCode = rcode;
            Descripcion = rdescripcion;
            CodigoUnidad = codigoUnidad;


        }
    }
}
