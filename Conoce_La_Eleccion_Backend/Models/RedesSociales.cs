using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class RedesSociales
    {
        [Key]
        public int IdRedesSociales {  get; set; }

        public string Url {  get; set; }

        public int IdTipoRedSocial {  get; set; }
        public TipoRedSocial TipoRedSocial { get; set; }
        
        public int IdAspirante { get; set; }
        public Aspirante Aspirante { get; set; }
        
    }
}
