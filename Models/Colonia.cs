using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Colonia
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Ciudad { get; set; }

    public int? Municipio { get; set; }

    public string? Asentamiento { get; set; }

    public int? CodigoPostal { get; set; }

    public virtual ICollection<Datosgeneralesalumno> Datosgeneralesalumnos { get; set; } = new List<Datosgeneralesalumno>();

    public virtual ICollection<Datosgeneralestrabajadore> Datosgeneralestrabajadores { get; set; } = new List<Datosgeneralestrabajadore>();

    public virtual Municipio? MunicipioNavigation { get; set; }
}
