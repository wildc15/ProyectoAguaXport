using System;
using System.Collections.Generic;

namespace ProyectoXport.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public int? Stock { get; set; }

    public int? IdProveedor { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Proveedore? IdProveedorNavigation { get; set; }
}
