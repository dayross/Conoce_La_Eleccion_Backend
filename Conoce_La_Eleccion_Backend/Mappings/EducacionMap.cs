using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class EducacionMap : IEntityTypeConfiguration<Educacion>
    {
        public void Configure(EntityTypeBuilder<Educacion> builder)
        {
            builder.ToTable("Educacion").HasKey(edu => edu.IdEducacion);
            builder.ToTable("Educacion").HasOne(edu => edu.Aspirante).WithMany().HasForeignKey(edu => edu.IdAspirante);
        }
    }
}
