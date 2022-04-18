using Microsoft.EntityFrameworkCore;
using MonitorDatabaseEF.Modelo;

namespace MonitorDatabaseEF.Infrastructure
{
    public class DatabaseDataContext : DbContext
    {
        public DatabaseDataContext(DbContextOptions<DatabaseDataContext> options) : base(options)
        {

        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
