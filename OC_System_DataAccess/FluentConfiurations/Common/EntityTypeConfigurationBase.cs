
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OC_System.Domain.Common;


namespace OC_System_DataAccess.FluentConfiurations.Common
{
    public class EntityTypeConfigurationBase<T> : IEntityTypeConfiguration<T> where T : Entity {
    
    public virtual void Configure(EntityTypeBuilder<T> builder) { 
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id). IsRequired();

        
        } 

    
    }
    
}
