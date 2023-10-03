using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicioSocial.Models;

public partial class Grupos
{
    public string Id { get; set; } = null!;

    [Display(Name = "Docente")]
    public int IdDocente { get; set; }

    [Display(Name = "Materias")]
    public string IdMateria { get; set; } = null!;

    [Display(Name = "Cantidad de Alumnos")]
    public sbyte LimiteAlumnos { get; set; }

    [Display(Name = "Aula")]
    public short IdAula { get; set; }

    [Display(Name = "Modalidad")]
    public sbyte IdModalidad { get; set; }

    public string Grupo1 { get; set; } = null!;

    [Display(Name = "Aula")]
    public virtual Aulas IdAulaNavigation { get; set; } = null!;

    [Display(Name = "Docente")]
    public virtual Docentes IdDocenteNavigation { get; set; } = null!;

    [Display(Name = "Materia")]
    public virtual Materias IdMateriaNavigation { get; set; } = null!;

    [Display(Name = "Modalidad")]
    public virtual Modalidades IdModalidadNavigation { get; set; } = null!;

//    public virtual ICollection<Lista> Lista { get; set; } = new List<Lista>();
}
