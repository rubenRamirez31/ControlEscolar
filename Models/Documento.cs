using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Documento
{
    public short Id { get; set; }

    public string? IdAlumno { get; set; }

    public byte[]? ActaNacimiento { get; set; }

    public byte[]? CertificadoSecundaria { get; set; }

    public byte[]? ComprobanteDomicilio { get; set; }

    public virtual Alumno? IdAlumnoNavigation { get; set; }
}
