using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Estatusalumno
{
    public string Id { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();
}
