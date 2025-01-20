using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class CorreoElectronicoMap : IEntityTypeConfiguration<CorreoElectronico>
    {
        public void Configure(EntityTypeBuilder<CorreoElectronico> builder)
        {
            builder.ToTable("CorreoElectronico").HasKey(ce => ce.IdCorreoElectronico);
            builder.ToTable("CorreoElectronico").HasOne(ce => ce.Aspirante).WithMany().HasForeignKey(ce => ce.IdAspirante);
        }
    }
}
