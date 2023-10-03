using System;
using System.Collections.Generic;

#nullable disable


namespace ServicioSocial.Models;

public partial class Carreras
{

    public Carreras()
{
    Alumnos = new HashSet<Alumnos>();
    Docentes = new HashSet<Docentes>();
    Especialidades = new HashSet<Especialidades>();
    Materias = new HashSet<Materias>();
}

    public sbyte Id { get; set; }

    public string Carrera1 { get; set; } = null!;

    public DateOnly InicioVigencia { get; set; }

    public DateOnly? FinVigencia { get; set; }

    public virtual ICollection<Alumnos> Alumnos { get; set; } = new List<Alumnos>();

    public virtual ICollection<Docentes> Docentes { get; set; } = new List<Docentes>();

    public virtual ICollection<Especialidades> Especialidades { get; set; } = new List<Especialidades>();

    public virtual ICollection<Materias> Materias { get; set; } = new List<Materias>();
}
