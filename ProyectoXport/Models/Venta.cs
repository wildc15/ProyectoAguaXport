using System;
using System.Collections.Generic;

namespace ProyectoXport.Models;

public partial class Venta
{
    public int IdVenta { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEmpleado { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }
}
