using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServicioSocial.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NomUsuario { get; set; }

        public string Pwd { get; set; }

        public int IdRol { get; set; }

        public Roles Rol { get; set; }
    }
}