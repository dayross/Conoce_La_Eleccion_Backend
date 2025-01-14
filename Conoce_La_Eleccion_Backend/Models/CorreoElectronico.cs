using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class CorreoElectronico
    {
        [Key]
        public int IdCorreoElectronico { get; set; }
        [Required]
        public string Descripcion { get; set; }
        
        public int IdAspirante { get; set; }
        public Aspirante Aspirante { get; set; }
    }
}
