using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class Educacion
    {
        [Key]
        public int IdEducacion {  get; set; }
        [Required]
        public string Descripcion {  get; set; }
        [Required]
        public string ImpartidoPor { get; set; }
        [Required]
        public DateTime FechaFin {  get; set; }
        
        public int IdAspirante {  get; set; }
       
        public Aspirante Aspirante {  get; set; }
    }
}
