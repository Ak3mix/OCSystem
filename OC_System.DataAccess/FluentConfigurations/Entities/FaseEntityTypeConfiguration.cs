using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC_System.Dominio.Entities;
using OC_System.DataAccess.FluentConfigurations.Common;

namespace OC_System.DataAccess.FluentConfigurations.Entities
{


    public class FaseEntityTypeConfiguration
        : EntityTypeConfigurationBase<Fase>
    {
        public override void Configure(EntityTypeBuilder<Fase> builder)
        {

            builder.ToTable("Fases");
            builder.Ignore(f => f.Recetas);
            builder.Ignore(f => f.Operaciones);
            base.Configure(builder);

        }
    }
}

