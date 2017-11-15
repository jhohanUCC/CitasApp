using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citas.Data.Entities
{
    public class AspNetUser
    {
        public string Id { get; set; }

        public bool ChangePassword { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public int Edad { get; set; }

        public bool Genero { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string Direccion { get; set; }

        public DateTime FechaModificacion { get; set; }

        public string UsuarioModifico { get; set; }

        public DateTime UltimoAcceso { get; set; }

        public bool ValidaAdmin { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Identificacion { get; set; }

        public int? IdEspecialidad { get; set; }
    }
}
