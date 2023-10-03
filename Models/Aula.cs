using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Aula
{
    public short Id { get; set; }

    public string Aula1 { get; set; } = null!;

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();
}
