using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class Cargo
    {
        [Key] 
        public int IdCargo { get; set; }
        [Required]
        public string Descripcion { get; set; }
    }
}
