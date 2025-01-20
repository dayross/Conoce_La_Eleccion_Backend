using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class RedesSocialesMap :IEntityTypeConfiguration<RedesSociales>
    {
        public void Configure(EntityTypeBuilder<RedesSociales> builder)
        {
            builder.ToTable("RedesSociales").HasKey(rs => rs.IdRedesSociales);
            builder.ToTable("RedesSociales").HasOne(rs => rs.Aspirante).WithMany().HasForeignKey(rs => rs.IdAspirante);
            builder.ToTable("RedesSociales").HasOne(rs => rs.TipoRedSocial).WithMany().HasForeignKey(rs => rs.IdTipoRedSocial);
        }
    }
}
