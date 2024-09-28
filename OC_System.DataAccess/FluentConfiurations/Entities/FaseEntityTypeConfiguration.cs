using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC_System_DataAccess.FluentConfiurations.Common;
using OC_System.Dominio.Entities;

namespace OC_System_DataAccess.FluentConfiurations.Entities
{
  
    
    internal class FaseEntityTypeConfiguration
        : EntityTypeConfigurationBase<Fase>
    {
        public override void Configure(EntityTypeBuilder<Fase> builder)
        {
            /// <summary>
            /// Nombre de la tabla: "Variables"
            /// </summary>
            builder.ToTable("Fases");
            /// <summary>
            /// Relacion de uno a muchos con MeasurementUnit
            /// </summary>
            builder.HasOne(x => x.Receta)
                .WithMany()
                .HasForeignKey(x => x.RecetaId);
            builder.Ignore(x => x.Receta);
            builder.Ignore(x => x.Operacion);
            base.Configure(builder);

        }
    }
}

