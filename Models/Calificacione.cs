using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Calificacione
{
    public short Id { get; set; }

    public string? IdAlumno { get; set; }

    public string? IdMateria { get; set; }

    public int? Calificacion { get; set; }

    public virtual Alumno? IdAlumnoNavigation { get; set; }

    public virtual Materia? IdMateriaNavigation { get; set; }
}
