using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Votaciones.Modelos
{
    public class Voto
    {
        [Key] public int VotoId { get; set; } // PK

        public int EleccionId { get; set; }
        public Eleccion Eleccion { get; set; }

        public int CandidatoId { get; set; }
        public Candidato Candidato { get; set; }

        public string HashVotante { get; set; } // anonimato
        public DateTime FechaRegistro { get; set; }
    }

}
