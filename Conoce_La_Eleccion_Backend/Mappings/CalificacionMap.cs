using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class CalificacionMap : IEntityTypeConfiguration<Calificacion>
    {
        public void Configure(EntityTypeBuilder<Calificacion> builder)
        {
            builder.ToTable("Calificacion").HasKey(calif => calif.IdCalificacion);
            builder.ToTable("Calificacion").HasOne(calif => calif.Aspirante).WithMany().HasForeignKey(calif => calif.IdAspirante);
        }
    }
}
