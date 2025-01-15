using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Conoce_La_Eleccion_Backend.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Aspirante> DatosAspirante { get; set; } = null;
    }
}
