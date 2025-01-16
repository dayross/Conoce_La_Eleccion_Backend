using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Conoce_La_Eleccion_Backend.Context
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseNpgsql(Configuration.GetConnectionString("ConnStringPgsql"));
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aspirante> Aspirante { get; set; }
        public DbSet<Calificacion> Calificacion { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<CorreoElectronico> CorreoElectronico { get; set; }
        public DbSet<Educacion> Educacion { get; set; }
        public DbSet<Experiencia> Experiencia { get; set; }
        public DbSet<RedesSociales> RedesSociales { get; set; }
        public DbSet<Telefono> Telefono { get; set; }
        public DbSet<TipoRedSocial> TipoRedSocial { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
