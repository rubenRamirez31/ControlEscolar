using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Periodo
{
    public sbyte Id { get; set; }

    public string Periodo1 { get; set; } = null!;

    public DateOnly Inicio { get; set; }

    public DateOnly Fin { get; set; }

    public ulong Activo { get; set; }

    public virtual ICollection<Kardex> Kardices { get; set; } = new List<Kardex>();

    public virtual ICollection<Lista> Lista { get; set; } = new List<Lista>();
}
