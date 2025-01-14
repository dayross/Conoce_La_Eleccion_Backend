using System.ComponentModel.DataAnnotations;


namespace Conoce_La_Eleccion_Backend.Models
{
    public class Telefono
    {
        [Key]
        public int IdTelefono { get; set; }
        [Required]
        public string NumTelefono { get; set; }
        [Required]
        public bool Whatsapp { get; set; }

        public int IdAspirante { get; set; }
        public Aspirante Aspirante { get; set; }
        
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

    }
}
