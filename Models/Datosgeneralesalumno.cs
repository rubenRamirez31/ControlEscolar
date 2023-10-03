using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicioSocial.Models;

public partial class Datosgeneralesalumno
{
    public Datosgeneralesalumno()
    {
        Alumnos = new HashSet<Alumnos>();
    }
    public string Curp { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    [Display(Name ="Apellido Paterno")]
    public string Apaterno { get; set; } = null!;

    public string Amaterno { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public string? Direccion { get; set; }

    public int Cp { get; set; }

    public int IdLocalidad { get; set; }

    public string? UrlFoto { get; set; }

    public virtual ICollection<Alumnos> Alumnos { get; set; } = new List<Alumnos>();

    public virtual Colonias IdLocalidadNavigation { get; set; } = null!;
}
