using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicioSocial.Models;

public partial class Documentos
{
    public short Id { get; set; }

    [Display(Name = "Alumno")]
    public string? IdAlumno { get; set; }

     [Display(Name = "Acta de Nacimiento")]
    public byte[]? ActaNacimiento { get; set; }

    [Display(Name = "Certificado de Secundaria")]
    public byte[]? CertificadoSecundaria { get; set; }

    [Display(Name = "Comprobante de Domicilio")]
    public byte[]? ComprobanteDomicilio { get; set; }

    //public virtual Alumnos? IdAlumnoNavigation { get; set; }
}
