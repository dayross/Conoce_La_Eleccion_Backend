using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class TelefonoMap : IEntityTypeConfiguration<Telefono>
    {
        public void Configure(EntityTypeBuilder<Telefono> builder)
        {
            builder.ToTable("Telefono").HasKey(tel => tel.IdTelefono);
            builder.ToTable("Telefono").HasOne(tel => tel.Aspirante).WithMany().HasForeignKey(tel => tel.IdAspirante);
            builder.ToTable("Telefono").HasOne(tel => tel.Usuario).WithMany().HasForeignKey(tel => tel.IdUsuario);
        }
    }
}
