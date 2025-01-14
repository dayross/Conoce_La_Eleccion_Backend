using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class TipoRedSocial
    {
        [Key]
        public int IdTipoRedSocial { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
