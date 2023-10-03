using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicioSocial.Models;

public partial class Calificaciones
{

    public short Id { get; set; }

    [Display(Name = "Alumno")]
    public string? IdAlumno { get; set; }

    [Display(Name = "Materia")]
    public string? IdMateria { get; set; }

    [Display(Name = "Calificación")]
    public int? Calificacion { get; set; }

    // public virtual Alumnos? IdAlumnoNavigation { get; set; }

    // public virtual Materias? IdMateriaNavigation { get; set; }
}
