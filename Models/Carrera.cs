using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Carrera
{
    public sbyte Id { get; set; }

    public string Carrera1 { get; set; } = null!;

    public DateOnly InicioVigencia { get; set; }

    public DateOnly? FinVigencia { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual ICollection<Docente> Docentes { get; set; } = new List<Docente>();

    public virtual ICollection<Especialidade> Especialidades { get; set; } = new List<Especialidade>();

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();
}
