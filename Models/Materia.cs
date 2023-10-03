using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Materia
{
    public string Id { get; set; } = null!;

    public string Materia1 { get; set; } = null!;

    public sbyte IdCarrera { get; set; }

    public sbyte Creditos { get; set; }

    public bool? EsEspecialidad { get; set; }

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    public virtual ICollection<Grupo> Grupos { get; set; } = new List<Grupo>();

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;

    public virtual ICollection<Kardex> Kardices { get; set; } = new List<Kardex>();
}
