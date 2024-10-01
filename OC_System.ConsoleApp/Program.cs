using Microsoft.EntityFrameworkCore;
using OC_System.DataAccess.Concrete;
using OC_System.Dominio.Entities;
using System.Diagnostics;
using System;

namespace OC_System.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationContext appcontext = new ApplicationContext("Data Source= OC_SystemDB.sqlite");

            if (!appcontext.Database.CanConnect())
            {
                appcontext.Database.Migrate();
            }

            //var receta1 = new Receta("Receta1", "R001", "Descripcion de Receta1", "Unidad1");
            //var receta2 = new Receta("Receta2", "R002", "Descripcion de Receta2", "Unidad2");

            // Create instances of Operacion
            //var operacion1 = new Operacion("Operacion1", "O001", "Descripcion de Operacion1", "Unidad1");
            //var operacion2 = new Operacion("Operacion2", "O002", "Descripcion de Operacion2", "Unidad2");

            // Create instances of Fase
            //var fase1 = new Fase("Fase1", "F001", "Descripcion de Fase1", receta1);
            //var fase2 = new Fase("Fase2", "F002", "Descripcion de Fase2", receta2);


            //appcontext.Fases.Add(fase1);
            //appcontext.Fases.Add(fase2);

            //appcontext.Recetas.Add(receta1);
            //appcontext.Recetas.Add(receta2);

            //appcontext.Operacions.Add(operacion1);
            //appcontext.Operacions.Add(operacion2 );
            //appcontext.SaveChanges();

            //Receta loadedreceta = appcontext.Set<Receta>().FirstOrDefault(r => r.Id == fase1.RecetaId);
            //Console.WriteLine($"El codigo de la receta a partir de la fase es {loadedreceta.Code} ");
               }
    }
}
