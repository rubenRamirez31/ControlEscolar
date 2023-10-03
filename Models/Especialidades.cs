using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Especialidades
{
    public Especialidades()
{
    Alumnos = new HashSet<Alumnos>();
}
    public short Id { get; set; }

    public string Especialidad { get; set; } = null!;

    public sbyte IdCarrera { get; set; }

    public virtual ICollection<Alumnos> Alumnos { get; set; } = new List<Alumnos>();

    public virtual Carreras IdCarreraNavigation { get; set; } = null!;
}
