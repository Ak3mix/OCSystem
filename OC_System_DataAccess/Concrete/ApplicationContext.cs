using Microsoft.EntityFrameworkCore;
using OC_System.Domain.Entities;
using OC_System_DataAccess.FluentConfiurations.Entities;

namespace OC_System_DataAccess.Concrete
{
    public class ApplicationContext : DbContext
    {

        #region Tables
        public DbSet<Fase> Fases { get; set; }
        public DbSet<Operacion> Operacions { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        #endregion

        public ApplicationContext() { }
        public ApplicationContext(string connectionString)
               : base(GetOptions(connectionString))
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
              : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Fase>().ToTable("Fases");
            modelBuilder.Entity<Receta>().ToTable("Recetas");
            modelBuilder.Entity<Operacion>().ToTable("Operaciones");

            //modelBuilder.ApplyConfiguration(new FaseEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new OperacionEntityTypeConfiguration());
            //modelBuilder.ApplyConfiguration(new RecetaEntityTypeConfiguration());

        }


        private static DbContextOptions GetOptions(string connectionString)
        {
            return new DbContextOptionsBuilder().UseSqlite(connectionString).Options;
        }

    }
}