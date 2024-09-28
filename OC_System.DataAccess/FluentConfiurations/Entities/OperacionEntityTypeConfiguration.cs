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
    public class OperacionEntityTypeConfiguration : EntityTypeConfigurationBase<Operacion>

    {
        public override void Configure(EntityTypeBuilder<Operacion> builder)

        {
            builder.ToTable("Operaciones");
            builder.Ignore(x => x.Fase);
            builder.Ignore(x => x.Receta);
            base.Configure(builder);

        }
    }
}
