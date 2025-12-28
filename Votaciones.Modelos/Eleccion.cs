using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Votaciones.Modelos
{
    public class Eleccion
    {
        [Key] public int EleccionId { get; set; } // PK

        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public string Tipo { get; set; } // Nominal / Plancha
        public bool Cerrada { get; set; }

        // Navegación
        public ICollection<Candidato> Candidatos { get; set; }
        public ICollection<Voto> Votos { get; set; }
    }

}
