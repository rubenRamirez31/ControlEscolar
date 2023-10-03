using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Especialidade
{
    public short Id { get; set; }

    public string Especialidad { get; set; } = null!;

    public sbyte IdCarrera { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;
}
