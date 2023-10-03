using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Alumno
{
    public string NoControl { get; set; } = null!;

    public string Curp { get; set; } = null!;

    public sbyte IdCarrera { get; set; }

    public sbyte IdModalidad { get; set; }

    public short IdEspecialidad { get; set; }

    public sbyte Semestre { get; set; }

    public string IdEstatus { get; set; } = null!;

    public string Pwd { get; set; } = null!;

    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    public virtual Datosgeneralesalumno CurpNavigation { get; set; } = null!;

    public virtual Documento? Documento { get; set; }

    public virtual Carrera IdCarreraNavigation { get; set; } = null!;

    public virtual Especialidade IdEspecialidadNavigation { get; set; } = null!;

    public virtual Estatusalumno IdEstatusNavigation { get; set; } = null!;

    public virtual Modalidade IdModalidadNavigation { get; set; } = null!;

    public virtual ICollection<Kardex> Kardices { get; set; } = new List<Kardex>();
}
