using Datos.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Datos
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public  DbSet<Estudiante> Estudiante{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Estudiante>().ToTable("Etudiante");
        }
    }
}
