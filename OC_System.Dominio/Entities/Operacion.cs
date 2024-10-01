using OC_System.Dominio.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OC_System.Dominio.Entities
{
    public class Operacion : Entity
    {
        public string Nombre { get; set; }
        public string Code { get; set; }
        public string Descripcion { get; set; }
        public string CodigoUnidad { get; set; }

        public List<Receta> Recetas { get; set; }
        public List<Fase> Fases { get; set; }



        protected Operacion() { }
        public Operacion(Guid id, string onombre, string ocode, string odescripcion, string codigoUnidad) : base(id)

        {
            Nombre = onombre;
            Code= ocode;
            Descripcion = odescripcion;
            CodigoUnidad = codigoUnidad;
            Recetas= new List<Receta>();
            Fases= new List<Fase>();


        }

    }
}

