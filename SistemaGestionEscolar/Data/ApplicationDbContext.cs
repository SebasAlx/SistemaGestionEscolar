using Microsoft.EntityFrameworkCore;
using SistemaGestionEscolar.Models;

namespace SistemaGestionEscolar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}
