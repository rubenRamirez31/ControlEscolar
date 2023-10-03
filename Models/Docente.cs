using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Docente
{
    public int Id { get; set; }

    public string Rfc { get; set; } = null!;

    public sbyte IdCarrera { get; set; }

    public sbyte Horas { get; set; }

    public string Usuario { get; set; } = null!;

    public string Pwd { get; set; } = null!;

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;
}
