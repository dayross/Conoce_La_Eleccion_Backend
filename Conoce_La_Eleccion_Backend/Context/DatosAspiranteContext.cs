using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Conoce_La_Eleccion_Backend.Context
{
    public class DatosAspiranteContext : DbContext
    {
        public DatosAspiranteContext(DbContextOptions<DatosAspiranteContext> options) : base(options)
        {

        }

        public DbSet<Aspirante> DatosAspirante { get; set; } = null;
    }
}
