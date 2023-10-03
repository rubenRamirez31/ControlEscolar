using System;
using System.Collections.Generic;

#nullable disable


namespace ServicioSocial.Models;

public partial class Tipoacreditado
{
    public Tipoacreditado()
    {
        Kardex = new HashSet<Kardex>();
    }
    public sbyte Id { get; set; }

    public string Tipo { get; set; } = null!;

    public virtual ICollection<Kardex> Kardex { get; set; }
}
