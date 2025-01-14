namespace Conoce_La_Eleccion_Backend.Models
{
    public class Aspirante
    {
        public int IdAspirante { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public int Edad { get; set; }

        public string Presentacion { get; set; }

        public int IdCargo { get; set; }
        public Cargo Cargo { get; set; }

    }
}
