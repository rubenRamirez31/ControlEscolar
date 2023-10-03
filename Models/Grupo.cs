using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Grupo
{
    public string Id { get; set; } = null!;

    public int IdDocente { get; set; }

    public string IdMateria { get; set; } = null!;

    public sbyte LimiteAlumnos { get; set; }

    public short IdAula { get; set; }

    public sbyte IdModalidad { get; set; }

    public string Grupo1 { get; set; } = null!;

    public virtual Aula IdAulaNavigation { get; set; } = null!;

    public virtual Docente IdDocenteNavigation { get; set; } = null!;

    public virtual Materia IdMateriaNavigation { get; set; } = null!;

    public virtual Modalidade IdModalidadNavigation { get; set; } = null!;

    public virtual ICollection<Lista> Lista { get; set; } = new List<Lista>();
}
