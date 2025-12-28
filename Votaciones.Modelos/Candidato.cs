using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Votaciones.Modelos
{
    public class Candidato
    {
        [Key] public int CandidatoId { get; set; } // PK

        public string Nombre { get; set; }

        // FK
        public int EleccionId { get; set; }
        public Eleccion Eleccion { get; set; }

        // FK opcional (si el candidato es un usuario del sistema)
        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Voto> Votos { get; set; }
    }

}
