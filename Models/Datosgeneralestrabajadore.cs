﻿using System;
using System.Collections.Generic;

namespace ServicioSocial.Models;

public partial class Datosgeneralestrabajadore
{
    public string Rfc { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apaterno { get; set; } = null!;

    public string Amaterno { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public string Sexo { get; set; } = null!;

    public byte[]? Foto { get; set; }

    public string? Direccion { get; set; }

    public int Cp { get; set; }

    public int IdLocalidad { get; set; }

    public ulong EsDocente { get; set; }

    public virtual Colonia IdLocalidadNavigation { get; set; } = null!;
}
