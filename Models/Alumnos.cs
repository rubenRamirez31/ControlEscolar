using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

#nullable disable

public partial class Alumnos
{

    public Alumnos()
{
    Kardex = new HashSet<Kardex>(); //
}

    public string NoControl { get; set; } = null!;

    public string Curp { get; set; } = null!;

    public sbyte IdCarrera { get; set; }

    public sbyte IdModalidad { get; set; }

    public short IdEspecialidad { get; set; }

    public sbyte Semestre { get; set; }

    public string IdEstatus { get; set; } = null!;

    public string Pwd { get; set; } = null!;

    public virtual ICollection<Calificaciones> Calificaciones { get; set; } = new List<Calificaciones>();

    public virtual Datosgeneralesalumno CurpNavigation { get; set; } = null!;

    public virtual Documentos Documentos { get; set; }

    public virtual Carreras IdCarreraNavigation { get; set; } = null!;

    public virtual Especialidades IdEspecialidadNavigation { get; set; } = null!;

    public virtual Estatusalumno IdEstatusNavigation { get; set; } = null!;

    public virtual Modalidades IdModalidadNavigation { get; set; } = null!;

    public virtual ICollection<Kardex> Kardex { get; set; } = new List<Kardex>(); //el nombre se cambio de kardex a kardixes "averiguar porque aparecia de esa manera"
}
