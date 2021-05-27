using Microsoft.EntityFrameworkCore;

namespace CalificacionesApp
{
    class SqliteDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/calificaciones.db");
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}