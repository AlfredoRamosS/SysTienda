using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SysTienda.Models;

public partial class Servicio
{
    [Key]
    [Column("Servicio_Id")]
    public int ServicioId { get; set; }

    [Column("Servicio_Descripcion")]
    [StringLength(250)]
    [Unicode(false)]
    public string ServicioDescripcion { get; set; } = null!;
}
