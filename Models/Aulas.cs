using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Aulas
{

    public Aulas()
    {
        Grupos = new HashSet<Grupos>();
    }

    public short Id { get; set; }

    public string Aula1 { get; set; } = null!;

    public virtual ICollection<Grupos> Grupos { get; set; } = new List<Grupos>();
}
