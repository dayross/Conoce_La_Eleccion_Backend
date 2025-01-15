using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class Aspirante
    {
        [Key]
        public int IdAspirante { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellidos { get; set; }

        public int Edad { get; set; }

        public string Presentacion { get; set; }

        public int IdCargo { get; set; }
        public Cargo Cargo { get; set; }

    }
}
