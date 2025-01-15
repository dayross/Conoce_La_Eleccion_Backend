using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class Experiencia
    {
        [Key]
        public int IDExperiencia {  get; set; }
        [Required]
        public string Puesto { get; set; }
        [Required]
        public string Descripcion {  get; set; }

        public DateTime FechaInicio {  get; set; }

        public DateTime FechaFin {  get; set; }
        [Required]
        public string LugarTrabajo {  get; set; }
        
        public int IdAspirante {  get; set; }

        public Aspirante Aspirante { get; set; }
    }
}
