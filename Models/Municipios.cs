using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Municipios
{
    public Municipios()
{
    Colonias = new HashSet<Colonias>();
}
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Estado { get; set; }

    public virtual ICollection<Colonias> Colonias { get; set; } = new List<Colonias>();

    public virtual Estados EstadoNavigation { get; set; } = null!;
}
