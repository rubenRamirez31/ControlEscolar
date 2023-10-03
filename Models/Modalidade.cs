using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Modalidade
{
    public sbyte Id { get; set; }

    public string Modalidad { get; set; } = null!;

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();
}
