using Microsoft.EntityFrameworkCore;
using AcademiaTangoApp.Models;

namespace AcademiaTangoApp.Data
{
    public class AcademiaContext : DbContext
    {
        public AcademiaContext(DbContextOptions<AcademiaContext> options) : base(options) { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Clase> Clases { get; set; }
    }
}

