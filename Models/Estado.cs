using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Estado
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Pais { get; set; }

    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();

    public virtual Paise PaisNavigation { get; set; } = null!;
}
