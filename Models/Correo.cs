using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//#nullable disable habilitar o no esta anotacion


namespace ServicioSocial.Models
{
    public class Correo
    {
        public string Servidor { get; set; }
        public string Remitente { get; set; }
        public string Destinatarios { get; set; }
        public string? DestinatariosCC { get; set; }
        public string? DestinatariosCCO { get; set; }
        public string User { get; set; }
        public string? Password { get; set; }
        public int Puerto { get; set; }
        public string Mensaje { get; set; }
        public string Asunto { get; set; }
        public bool? SSL { get; set; }
        public bool? Html { get; set; }
    }
}