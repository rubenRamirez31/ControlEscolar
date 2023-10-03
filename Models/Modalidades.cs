using System;
using System.Collections.Generic;

#nullable disable


namespace ServicioSocial.Models;

public partial class Modalidades
{
    public Modalidades()
    {
        Alumnos = new HashSet<Alumnos>();
        Grupos = new HashSet<Grupos>();
    }
    public sbyte Id { get; set; }

    public string Modalidad { get; set; } = null!;

    public virtual ICollection<Alumnos> Alumnos { get; set; } = new List<Alumnos>();

    public virtual ICollection<Grupos> Grupos { get; set; } = new List<Grupos>();
}
