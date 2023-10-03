using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Lista
{
    public int Id { get; set; }

    public string IdGrupo { get; set; } = null!;

    public string NoControl { get; set; } = null!;

    public sbyte IdPeriodo { get; set; }

    public virtual Grupo IdGrupoNavigation { get; set; } = null!;

    public virtual Periodo IdPeriodoNavigation { get; set; } = null!;
}
