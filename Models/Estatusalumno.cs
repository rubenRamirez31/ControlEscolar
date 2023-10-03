using System;
using System.Collections.Generic;

#nullable disable


namespace ServicioSocial.Models;

public partial class Estatusalumno
{
    public Estatusalumno()
    {
        Alumnos = new HashSet<Alumnos>();
    }
    public string Id { get; set; } = null!;

    public string Estatus { get; set; } = null!;

    public virtual ICollection<Alumnos> Alumnos { get; set; } = new List<Alumnos>();
}
