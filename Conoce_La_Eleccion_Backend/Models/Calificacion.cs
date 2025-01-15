using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class Calificacion
    {
        [Key]
        public int IdCalificacion { get; set; }
        [Required]
        public int Puntuacion { get; set; }

        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }

        public int IdAspirante { get; set; }

        public Aspirante Aspirante { get; set; }
    }
}
