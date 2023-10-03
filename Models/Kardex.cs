using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Kardex
{
    public int Id { get; set; }

    public string IdMateria { get; set; } = null!;

    public string NoControl { get; set; } = null!;

    public sbyte Calificacion { get; set; }

    public sbyte IdPeriodo { get; set; }

    public sbyte? IdTipoAcreditado { get; set; }

    public virtual Materia IdMateriaNavigation { get; set; } = null!;

    public virtual Periodo IdPeriodoNavigation { get; set; } = null!;

    public virtual Tipoacreditado? IdTipoAcreditadoNavigation { get; set; }

    public virtual Alumno NoControlNavigation { get; set; } = null!;
}
