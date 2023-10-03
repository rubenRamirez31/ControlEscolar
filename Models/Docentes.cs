using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable


namespace ServicioSocial.Models;

public partial class Docentes
{
    public int Id { get; set; }

    [Display(Name = "RFC")]
    public string Rfc { get; set; } = null!;

    [Display(Name = "Carrera")]
    public sbyte IdCarrera { get; set; }

    public sbyte Horas { get; set; }

    public string Usuario { get; set; } = null!;

    [Display(Name = "Contraseña")]
    public string Pwd { get; set; } = null!;

    public virtual ICollection<Grupos> Grupos { get; set; } = new List<Grupos>();

    [Display(Name = "Carrera")]
    public virtual Carreras IdCarreraNavigation { get; set; } = null!;
}
