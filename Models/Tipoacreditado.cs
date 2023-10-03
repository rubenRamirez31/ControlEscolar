using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Tipoacreditado
{
    public sbyte Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Kardex> Kardices { get; set; } = new List<Kardex>();
}
