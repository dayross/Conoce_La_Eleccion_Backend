using Conoce_La_Eleccion_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Conoce_La_Eleccion_Backend.Mappings
{
    public class TipoRedSocialMap : IEntityTypeConfiguration<TipoRedSocial>
    {
        public void Configure(EntityTypeBuilder<TipoRedSocial> builder)
        {
            builder.ToTable("TipoRedSocial").HasKey(trs => trs.IdTipoRedSocial);
        }
    }
}
