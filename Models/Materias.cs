using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ServicioSocial.Models;

public partial class Materias
{

     public Materias()
 {
     Grupos = new HashSet<Grupos>();
     Kardex = new HashSet<Kardex>();
 }

    public string Id { get; set; } = null!;

    public string Materia { get; set; } = null!;

    [Display(Name = "Carrera")]
    public sbyte IdCarrera { get; set; }

    public sbyte Creditos { get; set; }

    public bool? EsEspecialidad { get; set; }

    public virtual ICollection<Calificaciones> Calificaciones { get; set; } = new List<Calificaciones>();

    public virtual ICollection<Grupos> Grupos { get; set; } = new List<Grupos>();

    [Display(Name = "Carrera")]
    public virtual Carreras IdCarreraNavigation { get; set; } = null!;

    public virtual ICollection<Kardex> Kardices { get; set; } = new List<Kardex>();
}
