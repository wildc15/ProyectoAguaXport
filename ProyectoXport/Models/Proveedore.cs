﻿using System;
using System.Collections.Generic;

namespace ProyectoXport.Models;

public partial class Proveedore
{
    public int IdProveedor { get; set; }

    public string? Nombre { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
