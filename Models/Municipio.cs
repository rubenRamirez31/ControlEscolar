using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Municipio
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Estado { get; set; }

    public virtual ICollection<Colonia> Colonia { get; set; } = new List<Colonia>();

    public virtual Estado EstadoNavigation { get; set; } = null!;
}
