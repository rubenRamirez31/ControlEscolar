using System;
using System.Collections.Generic;

#nullable disable


namespace ServicioSocial.Models;

public partial class Estados
{
    public Estados()
    {
        Municipios = new HashSet<Municipios>();
    }

    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int Pais { get; set; }

    public virtual ICollection<Municipios> Municipios { get; set; } = new List<Municipios>();

    public virtual Paises PaisNavigation { get; set; } = null!;
}
