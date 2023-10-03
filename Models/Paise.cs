using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Paise
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Estado> Estados { get; set; } = new List<Estado>();
}
