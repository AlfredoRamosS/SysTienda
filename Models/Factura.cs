using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysTienda.Models;

public partial class Factura
{
    [Key]
    [Column("Factura_Id")]
    public int FacturaId { get; set; }

    [Column("Cliente_Id")]
    public int ClienteId { get; set; }

    [Column("Fecha_Factura")]
    public DateOnly FechaFactura { get; set; }

    [Column("Fecha_Vencimiento")]
    public DateOnly FechaVencimiento { get; set; }

    [Column("SubTotal_sin_iva", TypeName = "decimal(18, 2)")]
    public decimal SubTotalSinIva { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Descuento { get; set; }

    [Column("IVA", TypeName = "decimal(18, 2)")]
    public decimal Iva { get; set; }

    [Column("Total_con_Iva", TypeName = "decimal(18, 2)")]
    public decimal TotalConIva { get; set; }

    [Column("Importe_Pagado", TypeName = "decimal(18, 2)")]
    public decimal ImportePagado { get; set; }

    [Column("Importe_Pagar", TypeName = "decimal(18, 2)")]
    public decimal ImportePagar { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Factura")]
    public virtual Cliente Cliente { get; set; } = null!;
}
