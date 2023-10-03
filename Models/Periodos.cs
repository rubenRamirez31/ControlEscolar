using System;
using System.Collections.Generic;

#nullable disable


namespace ServicioSocial.Models;

public partial class Periodos
{

    public Periodos()
    {
        Kardex = new HashSet<Kardex>();
    }
    public sbyte Id { get; set; }

    public string Periodo1 { get; set; } = null!;

    public DateOnly Inicio { get; set; }

    public DateOnly Fin { get; set; }

    public ulong Activo { get; set; }

    public virtual ICollection<Kardex> Kardex { get; set; } = new List<Kardex>(); //Aparecia como kardices

   // public virtual ICollection<Lista> Lista { get; set; } = new List<Lista>();
}
