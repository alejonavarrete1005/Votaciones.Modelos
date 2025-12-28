using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Votaciones.Modelos.DTOs
{
    public class VotoDto
    {
        [Required]
        public int EleccionId { get; set; }

        [Required]
        public int CandidatoId { get; set; }
    }


}
