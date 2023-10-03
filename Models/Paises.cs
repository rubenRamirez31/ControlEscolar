using System;
using System.Collections.Generic;

#nullable disable


namespace ServicioSocial.Models;

public partial class Paises
{
    public Paises()
    {
        Estados = new HashSet<Estados>();
    }
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Estados> Estados { get; set; } = new List<Estados>();
}
