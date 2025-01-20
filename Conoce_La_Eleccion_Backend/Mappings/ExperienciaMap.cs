using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class ExperienciaMap : IEntityTypeConfiguration<Experiencia>
    {
        public void Configure(EntityTypeBuilder<Experiencia> builder)
        {
            builder.ToTable("Experiencia").HasKey(exp => exp.IdExperiencia);
            builder.ToTable("Experiencia").HasOne(exp => exp.Aspirante).WithMany().HasForeignKey(exp => exp.IdAspirante);
        }
    }
}
