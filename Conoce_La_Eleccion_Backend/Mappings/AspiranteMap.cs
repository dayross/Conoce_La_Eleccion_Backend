using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class AspiranteMap : IEntityTypeConfiguration<Aspirante>
    {
        public void Configure(EntityTypeBuilder<Aspirante> builder) { 
            builder.ToTable("Aspirante").HasKey(asp => asp.IdAspirante);
            builder.ToTable("Aspirante").HasOne(asp => asp.Cargo).WithMany().HasForeignKey(asp => asp.IdCargo);
        }
    }
}
