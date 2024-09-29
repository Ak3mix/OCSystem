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

    public List<Receta> Receta { get; set; } = new List<Receta>();
    public List<Fase> Fase { get; set; } = new List<Fase>();

    

    protected Operacion() { }
    public Operacion(string onombre, string ocode, string odescripcion, string codigoUnidad)
    {
        Nombre = onombre;
            Code= ocode;    
        Descripcion = odescripcion;
        CodigoUnidad = codigoUnidad;


    }
}
}
