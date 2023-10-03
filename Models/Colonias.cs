using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Colonias
{

    public Colonias()
{
    Datosgeneralesalumno = new HashSet<Datosgeneralesalumno>();
    Datosgeneralestrabajadores = new HashSet<Datosgeneralestrabajadores>();
}
    
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Ciudad { get; set; }

    public int? Municipio { get; set; }

    public string? Asentamiento { get; set; }

    public int? CodigoPostal { get; set; }

    public virtual ICollection<Datosgeneralesalumno> Datosgeneralesalumno { get; set; } = new List<Datosgeneralesalumno>();

    public virtual ICollection<Datosgeneralestrabajadores> Datosgeneralestrabajadores { get; set; } = new List<Datosgeneralestrabajadores>();

    public virtual Municipios? MunicipioNavigation { get; set; }
}
