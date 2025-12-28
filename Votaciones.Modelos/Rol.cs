using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Votaciones.Modelos
{
    public class Rol
    {
        [Key] public int RolId { get; set; } // PK

        public string Nombre { get; set; } // Admin, Votante, Candidato

        // Navegación
        public ICollection<UsuarioRol> UsuarioRoles { get; set; }
    }
}
