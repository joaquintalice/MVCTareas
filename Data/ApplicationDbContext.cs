using Microsoft.EntityFrameworkCore;
using TareasMVC.Entities;

namespace TareasMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // modelBuilder.Entity<Tarea>().Property(t => t.Titulo).HasMaxLength(250).IsRequired();
        }

        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Paso> Pasos { get; set; }
    }
}
