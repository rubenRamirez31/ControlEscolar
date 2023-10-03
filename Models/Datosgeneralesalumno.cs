using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Datosgeneralesalumno
{
    public string Curp { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apaterno { get; set; } = null!;

    public string Amaterno { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public string? Direccion { get; set; }

    public int Cp { get; set; }

    public int IdLocalidad { get; set; }

    public string? UrlFoto { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual Colonia IdLocalidadNavigation { get; set; } = null!;
}
