
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC_System.Dominio.Common;


namespace OC_System.DataAccess.FluentConfigurations.Common
{
    public class EntityTypeConfigurationBase<T> : IEntityTypeConfiguration<T> where T : Entity
    {

        public virtual void Configure(EntityTypeBuilder<T> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();


        }


    }

}
