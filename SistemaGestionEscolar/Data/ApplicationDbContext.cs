using Microsoft.EntityFrameworkCore;
using SistemaGestionEscolar.Models;

namespace SistemaGestionEscolar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Maestro> Maestros { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Materia> Materias { get; set; }
    }
}
