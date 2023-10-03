using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ServicioSocial.Models;

public partial class Kardex
{
    public int Id { get; set; }
    [Display(Name = "Materia")]

    public string IdMateria { get; set; } = null!;

    [Display(Name = "Numero de Control")]
    public string NoControl { get; set; } = null!;

    public sbyte Calificacion { get; set; }

    [Display(Name = "Periodo")]
    public sbyte IdPeriodo { get; set; }

    public sbyte? IdTipoAcreditado { get; set; }

    [Display(Name = "Materia")]
    public virtual Materias IdMateriaNavigation { get; set; } = null!;

    [Display(Name = "Periodo")]
    public virtual Periodos IdPeriodoNavigation { get; set; } = null!;

    [Display(Name = "Tipo de Acreditacion")]
    public virtual Tipoacreditado? IdTipoAcreditadoNavigation { get; set; }

    [Display(Name = "Numero de Control")]
    public virtual Alumnos NoControlNavigation { get; set; } = null!;
}
