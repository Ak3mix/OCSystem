using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC_System_DataAccess.FluentConfiurations.Common;
using OC_System.Domain.Entities;

namespace OC_System_DataAccess.FluentConfiurations.Entities
{
    public class RecetaEntityTypeConfiguration : EntityTypeConfigurationBase<Receta>

    {
        public override void Configure(EntityTypeBuilder<Receta> builder)

        {
            builder.ToTable("Recetas");
            builder.Ignore(x=> x.Fase);
            builder.Ignore(x => x.Operacion);
            base.Configure(builder);


        }
    }
}