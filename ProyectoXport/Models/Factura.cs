using System;
using System.Collections.Generic;

namespace ProyectoXport.Models;

public partial class Factura
{
    public int IdFactura { get; set; }

    public decimal? Precio { get; set; }

    public int? Cantidad { get; set; }

    public int? IdVenta { get; set; }

    public int? IdProducto { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Venta? IdVentaNavigation { get; set; }
}
