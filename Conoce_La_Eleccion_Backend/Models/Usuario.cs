﻿using System.ComponentModel.DataAnnotations;

namespace Conoce_La_Eleccion_Backend.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Nickname { get; set; }

    }
}
