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
    public string Descripcion { get; set; }
    public string CodigoUnidad { get; set; }

    public List<Receta> Receta { get; set; }
    public List<Fase> Fase { get; set; }

    [NotMapped]
    public List<double> Parametros { get; set; }


    protected Operacion() { }
    public Operacion(string onombre, string odescripcion, string codigoUnidad)
    {
        Nombre = onombre;

        Descripcion = odescripcion;
        CodigoUnidad = codigoUnidad;


    }
}
}
