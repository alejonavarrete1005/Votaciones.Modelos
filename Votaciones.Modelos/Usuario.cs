using System.ComponentModel.DataAnnotations;

namespace Votaciones.Modelos
{
    public class Usuario
    {
        [Key]public int UsuarioId { get; set; } // PK

        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public bool Activo { get; set; }

        // Navegación
        public ICollection<UsuarioRol> UsuarioRoles { get; set; }
    }
}
