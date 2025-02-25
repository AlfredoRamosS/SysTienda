using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysTienda.Models;

[Keyless]
[Table("Detalle_Factura")]
public partial class DetalleFactura
{
    [Column("Factura_Id")]
    public int FacturaId { get; set; }

    [Column("Servicio_Id")]
    public int ServicioId { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Precio { get; set; }

    [ForeignKey("FacturaId")]
    public virtual Factura Factura { get; set; } = null!;

    [ForeignKey("ServicioId")]
    public virtual Servicio Servicio { get; set; } = null!;
}
