using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysTienda.Models;

public partial class Cliente
{
    [Key]
    [Column("Cliente_Id")]
    public int ClienteId { get; set; }

    [Column("Cliente_Nombre")]
    [StringLength(50)]
    [Unicode(false)]
    public string ClienteNombre { get; set; } = null!;

    [Column("Cliente_Direccion")]
    [StringLength(100)]
    [Unicode(false)]
    public string ClienteDireccion { get; set; } = null!;

    [InverseProperty("Cliente")]
    public virtual ICollection<Factura> Factura { get; set; } = new List<Factura>();
}
