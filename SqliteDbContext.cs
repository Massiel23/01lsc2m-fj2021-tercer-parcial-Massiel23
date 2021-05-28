using Microsoft.EntityFrameworkCore;

namespace CalificacionesApp
{
    class SqliteDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/calificaciones.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlanDeEstudio>(a => {
                a.Property(p => p.Año).HasColumnName("Anio");
            });


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Escuela> Escuelas { get; set; }
        public DbSet<PlanDeEstudio> PlanesDeEstudio { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
    }
    
}